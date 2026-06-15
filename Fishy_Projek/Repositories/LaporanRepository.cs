using System;
using System.Collections.Generic;
using Npgsql;
using Fishy_Projek.Models;

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
                var cmd = new NpgsqlCommand("SELECT * FROM public.vw_ringkasan_stok", conn);
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
                string query = "SELECT * FROM vw_riwayat_mutasi_lengkap";
                if (filter != "SEMUA")
                    query += " WHERE jenis_mutasi = @filter";

                query += " ORDER BY waktu_transaksi DESC";

                var cmd = new NpgsqlCommand(query, conn);
                if (filter != "SEMUA") cmd.Parameters.AddWithValue("filter", filter);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new MutasiView
                    {
                        IdTransaksi = reader.GetString(0),
                        NamaIkan = reader.GetString(1),
                        NamaRuang = reader.GetString(2),
                        JenisMutasi = reader.GetString(3),
                        JumlahKg = reader.GetDouble(4),
                        WaktuTransaksi = reader.GetDateTime(5),
                        NamaOperator = reader.GetString(6),
                        AsalTujuan = reader.GetString(7)
                    });
            }
            return list;
        }
    }
}