using Fishy_Projek.Helpers;
using Fishy_Projek.Models;
using Npgsql;
using System;
using System.Collections.Generic;

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

        public List<MutasiView> GetRiwayatMutasi(string filter)
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
    }
}