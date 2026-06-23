using System;
using System.Collections.Generic;
using Npgsql;
using Fishy_Projek.Models;
using Fishy_Projek.Helpers;

namespace Fishy_Projek.Repositories
{
    public class OperasionalRepository
    {
        public User Login(string username, string password)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                // PASTIKAN URUTAN SELECT INI SAMA DENGAN KODINGAN DI BAWAH
                // 0: id_user (INT), 1: nama (STR), 2: password (STR), 3: id_role (INT), 4: username (STR)
                var sql = "SELECT id_user, nama, password, id_role, username FROM public.users WHERE username = @username AND password = @password";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Membaca data sesuai urutan SELECT di atas
                            int idUser = reader.GetInt32(0);     // 0: id_user
                            string nama = reader.GetString(1);   // 1: nama
                            string pass = reader.GetString(2);   // 2: password
                            int idRole = reader.GetInt32(3);     // 3: id_role
                            string user = reader.GetString(4);   // 4: username

                            // Membuat objek user
                            User loggedInUser = idRole == 1 ? (User)new Manager() : new Operator();

                            loggedInUser.IdUser = idUser;
                            loggedInUser.Nama = nama;
                            loggedInUser.Username = user;
                            loggedInUser.Password = pass;
                            loggedInUser.IdRole = idRole;

                            return loggedInUser;
                        }
                    }
                }
            }
            return null;
        }

        public void TerimaStok(string idMasuk, string idIkan, int idPihak, string idRuang, double kuantitasKg, int idUser)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "CALL public.sp_terima_stok(@id_masuk, @id_pihak, @id_ikan, @id_ruang, @jumlah, @id_user)", conn);
                cmd.Parameters.AddWithValue("id_masuk", idMasuk);
                cmd.Parameters.AddWithValue("id_pihak", idPihak);
                cmd.Parameters.AddWithValue("id_ikan", idIkan);
                cmd.Parameters.AddWithValue("id_ruang", idRuang);
                cmd.Parameters.AddWithValue("jumlah",kuantitasKg);
                cmd.Parameters.AddWithValue("id_user", idUser);
                cmd.ExecuteNonQuery();
            }
        }

        public void EksekusiStoredProcedureTerimaStok(string idMasuk, string idIkan, int idPihak, string idRuang, double kuantitasKg, int idUser)
        {
            TerimaStok(idMasuk, idIkan, idPihak, idRuang, kuantitasKg, idUser);
        }

        public void ProsesPengiriman(string idKeluar, string idMasuk, int idPihak, string noArmada, double kuantitasKirim, int idUser)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "CALL public.sp_proses_pengiriman(@id_keluar, @id_masuk, @id_pihak, @no_armada, @kuantitas_kirim, @id_user)", conn);
                cmd.Parameters.AddWithValue("id_keluar", idKeluar);
                cmd.Parameters.AddWithValue("id_masuk", idMasuk);
                cmd.Parameters.AddWithValue("id_pihak", idPihak);
                cmd.Parameters.AddWithValue("no_armada", noArmada);
                cmd.Parameters.AddWithValue("kuantitas_kirim", kuantitasKirim);
                cmd.Parameters.AddWithValue("id_user", idUser);
                cmd.ExecuteNonQuery();
            }
        }

        public void EksekusiStoredProcedurePengiriman(string idKeluar, string idMasuk, int idPihak, string noArmada, double kuantitasKirim, int idUser)
        {
            ProsesPengiriman(idKeluar, idMasuk, idPihak, noArmada, kuantitasKirim, idUser);
        }

        public void InputSuhu(string idRuang, double suhuAktual, string gradeMutu, string catatan, int idUser)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO public.batch_ikan (id_ruang, suhu_aktual, grade_mutu, catatan) VALUES (@idRuang, @suhu, @grade, @catatan)", conn);
                cmd.Parameters.AddWithValue("idRuang", idRuang);
                cmd.Parameters.AddWithValue("suhu", suhuAktual);
                cmd.Parameters.AddWithValue("grade", gradeMutu);
                cmd.Parameters.AddWithValue("catatan", catatan ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        public void SimpanBatchIkan(BatchIkan batch)
        {
            InputSuhu(batch.IdRuang, batch.SuhuAktualC, batch.GradeMutu, batch.Catatan, batch.IdUser);
        }

        public List<Stok> GetRingkasanStok()
        {
            var list = new List<Stok>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    @"SELECT 
                        0 AS id_stok,                     -- Index 0 (Int32)
                        bm.id_ikan,                       -- Index 1 (String)
                        bm.id_ruang,                      -- Index 2 (String)
                        SUM(bm.sisa_stok_kg) AS kuantitas_kg, -- Index 3 (Double)
                        i.nama_ikan,                      -- Index 4 (String)
                        rc.nama_ruang,                    -- Index 5 (String)
                        g.nama_gudang,                    -- Index 6 (String)
                        MAX(i.suhu_ideal) AS suhu_ideal,  -- Index 7 (Double)
                        MAX(i.batas_suhu) AS batas_suhu   -- Index 8 (Double)
                      FROM batch_masuk bm
                      JOIN ikan i ON bm.id_ikan = i.id_ikan
                      JOIN ruang_cooler rc ON bm.id_ruang = rc.id_ruang
                      JOIN gudang g ON rc.id_gudang = g.id_gudang
                      WHERE bm.sisa_stok_kg > 0
                      GROUP BY bm.id_ikan, bm.id_ruang, i.nama_ikan, rc.nama_ruang, g.nama_gudang", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Stok
                    {
                        IdStok = reader.GetInt32(0),
                        IdIkan = reader.GetString(1),
                        IdRuang = reader.GetString(2),
                        KuantitasKg = reader.GetDouble(3),
                        NamaIkan = reader.GetString(4),
                        NamaRuang = reader.GetString(5),
                        NamaGudang = reader.GetString(6),
                        SuhuIdeal = reader.GetDouble(7),
                        BatasSuhu = reader.GetDouble(8)
                    });
                }
            }
            return list;
        }

        public void ProsesKirim(string idPengiriman, int idUser, string tujuan, string armada, int idStok, double kuantitas)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                // Ambil id_masuk dari stok
                string idMasuk = "";
                using (var cmd = new NpgsqlCommand(
                    "SELECT id_masuk FROM batch_masuk WHERE sisa_stok_kg > 0 ORDER BY waktu_masuk ASC LIMIT 1", conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                        throw new Exception("Tidak ada stok tersedia untuk dikirim.");
                    idMasuk = result.ToString();
                }

                // Cari id_pihak dari tujuan
                int idPihak = 0;
                using (var cmd = new NpgsqlCommand(
                    "SELECT id_pihak FROM pihak_eksternal WHERE nama_pihak = @tujuan LIMIT 1", conn))
                {
                    cmd.Parameters.AddWithValue("tujuan", tujuan);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        idPihak = Convert.ToInt32(result);
                }

                // Panggil stored procedure pengiriman
                using (var cmd = new NpgsqlCommand(
                    "CALL public.sp_proses_pengiriman(@id_keluar, @id_masuk, @id_pihak, @no_armada, @kuantitas_kirim, @id_user)", conn))
                {
                    cmd.Parameters.AddWithValue("id_keluar", idPengiriman);
                    cmd.Parameters.AddWithValue("id_masuk", idMasuk);
                    cmd.Parameters.AddWithValue("id_pihak", idPihak);
                    cmd.Parameters.AddWithValue("no_armada", armada);
                    cmd.Parameters.AddWithValue("kuantitas_kirim", kuantitas);
                    cmd.Parameters.AddWithValue("id_user", idUser);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}