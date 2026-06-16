using System;
using System.Collections.Generic;
using Npgsql;
using Fishy_Projek.Models;
using Fishy_Projek.Helpers;

namespace Fishy_Projek.Repositories
{
    public class LaporanRepository
    {

        public List<Stok> GetRingkasanStok()
        {
            var list = new List<Stok>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM vw_ringkasan_stok", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new Stok
                    {
                        IdStok = reader.GetInt32(0),
                        IdIkan = reader.GetString(1),
                        NamaIkan = reader.GetString(2),
                        NamaGudang = reader.GetString(3),
                        IdRuang = reader.GetString(4),
                        NamaRuang = reader.GetString(5),
                        KuantitasKg = reader.GetDouble(6)
                    });
            }
            return list;
        }


        public List<MutasiView> GetRiwayatMutasi(string filter)
        {
            var list = new List<MutasiView>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                // 1. Tulis query dengan nama kolom eksplisit agar urutan indeks (0-9) terjamin
                string query = @"
            SELECT 
                kode_batch_masuk,   -- 0
                nama_ikan,          -- 1
                penyuplai_nelayan,  -- 2
                waktu_masuk,        -- 3
                kuantitas_awal_kg,  -- 4
                sisa_stok_kg,       -- 5
                surat_jalan_keluar, -- 6 (Bisa Null)
                tujuan_distribusi,  -- 7 (Bisa Null)
                kuantitas_keluar_kg,-- 8 (Bisa Null)
                waktu_keluar        -- 9 (Bisa Null)
            FROM vw_keterlacakan_batch";

                // 2. Filter Dinamis
                if (!string.IsNullOrEmpty(filter) && filter != "SEMUA")
                {
                    query += " WHERE nama_ikan = @filter";
                }

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(filter) && filter != "SEMUA")
                    {
                        cmd.Parameters.AddWithValue("filter", filter);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 3. Mapping Objek dengan Pengecekan DBNull
                            var item = new MutasiView
                            {
                                // Kolom 0-5 (Data Inbound - Diasumsikan selalu memiliki nilai)
                                KodeBatchMasuk = reader.GetString(0),
                                NamaIkan = reader.GetString(1),
                                PenyuplaiNelayan = reader.GetString(2),
                                WaktuMasuk = reader.GetDateTime(3),
                                KuantitasAwalKg = reader.GetDouble(4),
                                SisaStokKg = reader.GetDouble(5),

                                // Kolom 6-9 (Data Outbound - Wajib divalidasi IsDBNull)
                                SuratJalanKeluar = reader.IsDBNull(6) ? "-" : reader.GetString(6),
                                TujuanDistribusi = reader.IsDBNull(7) ? "-" : reader.GetString(7),

                                KuantitasKeluarKg = reader.IsDBNull(8)
                                                    ? (double?)null
                                                    : reader.GetDouble(8),

                                WaktuKeluar = reader.IsDBNull(9)
                                              ? (DateTime?)null
                                              : reader.GetDateTime(9)
                            };

                            list.Add(item);
                        }
                    }
                }
            }

            return list;
        }
    }
}