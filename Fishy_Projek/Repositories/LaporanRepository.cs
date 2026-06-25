using Fishy_Projek.Helpers;
using Fishy_Projek.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace Fishy_Projek.Repositories
{
    public class LaporanRepository
    {
        public List<MutasiView> GetRingkasanStok()
        {
            var list = new List<MutasiView>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                    SELECT bm.id_masuk, i.nama_ikan, pe.nama_pihak,
                           bm.kuantitas_awal_kg, bm.sisa_stok_kg, bm.waktu_masuk
                    FROM batch_masuk bm
                    JOIN ikan i ON bm.id_ikan = i.id_ikan
                    JOIN pihak_eksternal pe ON bm.id_pihak = pe.id_pihak", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new MutasiView
                            {
                                KodeBatchMasuk = reader["id_masuk"].ToString(),
                                NamaIkan = reader["nama_ikan"].ToString(),
                                PenyuplaiNelayan = reader["nama_pihak"].ToString(),
                                WaktuMasuk = Convert.ToDateTime(reader["waktu_masuk"]),
                                KuantitasAwalKg = Convert.ToDouble(reader["kuantitas_awal_kg"]),
                                SisaStokKg = Convert.ToDouble(reader["sisa_stok_kg"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        public DataTable GetRiwayatMutasi(string filter)
        {
            var dt = new DataTable();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                // Query ini yang akan memfilter berdasarkan pilihan Semua / Masuk / Keluar
                string sql = @"
            SELECT 'Masuk' AS jenis_mutasi, bm.id_masuk AS id_transaksi, i.nama_ikan, bm.waktu_masuk AS waktu, bm.kuantitas_awal_kg AS jumlah_kg
            FROM batch_masuk bm
            JOIN ikan i ON bm.id_ikan = i.id_ikan
            WHERE (@filter = 'SEMUA' OR @filter = 'MASUK')
            
            UNION ALL
            
            SELECT 'Keluar' AS jenis_mutasi, bk.id_keluar AS id_transaksi, i.nama_ikan, bk.waktu_keluar AS waktu, bk.kuantitas_keluar_kg AS jumlah_kg
            FROM batch_keluar bk
            JOIN batch_masuk bm ON bk.id_masuk = bm.id_masuk
            JOIN ikan i ON bm.id_ikan = i.id_ikan
            WHERE (@filter = 'SEMUA' OR @filter = 'KELUAR')
            ORDER BY waktu DESC";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("filter", filter.ToUpper());
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public double GetTotalStokRuang(string idRuang)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT fn_total_stok_ruang_batch(@id_ruang)", conn))
                {
                    cmd.Parameters.AddWithValue("id_ruang", idRuang);
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDouble(result) : 0;
                }
            }
        }

        public double GetSisaKapasitasRuang(string idRuang)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT fn_sisa_kapasitas_ruang(@id_ruang)", conn))
                {
                    cmd.Parameters.AddWithValue("id_ruang", idRuang);
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDouble(result) : 0;
                }
            }
        }

        public string GetStatusSuhuRuang(string idRuang, double suhuInput)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT fn_status_suhu_ruang(@id_ruang, @suhu)", conn))
                {
                    cmd.Parameters.AddWithValue("id_ruang", idRuang);
                    cmd.Parameters.AddWithValue("suhu", suhuInput);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Tidak diketahui";
                }
            }
        }

        public double GetTotalTerkirimBatch(string idMasuk)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT fn_total_terkirim_batch(@id_masuk)", conn))
                {
                    cmd.Parameters.AddWithValue("id_masuk", idMasuk);
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDouble(result) : 0;
                }
            }
        }

        // Data buat grafik "Ikan Masuk vs Keluar" di Laporan (khusus Manajer).
        // Mengumpulkan total kg masuk & keluar per tanggal, jumlahHari terakhir.
        public List<GrafikMutasiHarian> GetGrafikMutasiHarian(int jumlahHari = 14)
        {
            var list = new List<GrafikMutasiHarian>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                    SELECT
                        tanggal,
                        SUM(masuk_kg)  AS total_masuk_kg,
                        SUM(keluar_kg) AS total_keluar_kg
                    FROM (
                        SELECT
                            DATE(waktu_masuk)   AS tanggal,
                            kuantitas_awal_kg   AS masuk_kg,
                            0::double precision AS keluar_kg
                        FROM batch_masuk
                        WHERE waktu_masuk >= (CURRENT_DATE - (@jumlah_hari * INTERVAL '1 day'))

                        UNION ALL

                        SELECT
                            DATE(waktu_keluar)   AS tanggal,
                            0::double precision  AS masuk_kg,
                            kuantitas_keluar_kg  AS keluar_kg
                        FROM batch_keluar
                        WHERE waktu_keluar >= (CURRENT_DATE - (@jumlah_hari * INTERVAL '1 day'))
                    ) gabungan
                    GROUP BY tanggal
                    ORDER BY tanggal", conn))
                {
                    cmd.Parameters.AddWithValue("jumlah_hari", jumlahHari);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateOnly tanggalDb = reader.GetFieldValue<DateOnly>(0);
                            DateTime tanggalAman = tanggalDb.ToDateTime(TimeOnly.MinValue);

                            list.Add(new GrafikMutasiHarian
                            {
                                Tanggal = tanggalAman,
                                TotalMasukKg = reader.GetDouble(1),
                                TotalKeluarKg = reader.GetDouble(2)
                            });
                        }
                    }
                }
            }
            return list; 
        } 

        
        public DataTable GetKondisiRuanganTerakhir()
        {
            var dt = new DataTable();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM vw_kondisi_ruangan_terakhir", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    } 
} 