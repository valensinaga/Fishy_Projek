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

        public void TerimaStok(string idIkan, string idRuang, double jumlahKg, int idUser)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "CALL public.sp_terima_stok(@idIkan, @idRuang, @jumlah, @idUser)", conn);
                cmd.Parameters.AddWithValue("idIkan", idIkan);
                cmd.Parameters.AddWithValue("idRuang", idRuang);
                cmd.Parameters.AddWithValue("jumlah", jumlahKg);
                cmd.Parameters.AddWithValue("idUser", idUser);
                cmd.ExecuteNonQuery();
            }
        }

        public void EksekusiStoredProcedureTerimaStok(string idIkan, string idRuang, double jumlahKg, int idUser)
        {
            TerimaStok(idIkan, idRuang, jumlahKg, idUser);
        }

        public void ProsesKirim(string idPengiriman, int idUser, string tujuan, string noArmada, int idStok, double kuantitas)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "CALL public.sp_proses_pengiriman(@idPengiriman, @idUser, @tujuan, @armada, @idStok, @kuantitas)", conn);
                cmd.Parameters.AddWithValue("idPengiriman", idPengiriman);
                cmd.Parameters.AddWithValue("idUser", idUser);
                cmd.Parameters.AddWithValue("tujuan", tujuan);
                cmd.Parameters.AddWithValue("armada", noArmada);
                cmd.Parameters.AddWithValue("idStok", idStok);
                cmd.Parameters.AddWithValue("kuantitas", kuantitas);
                cmd.ExecuteNonQuery();
            }
        }

        public void EksekusiStoredProcedurePengiriman(string idPengiriman, int idUser, string tujuan, string noArmada, int idStok, double kuantitas)
        {
            ProsesKirim(idPengiriman, idUser, tujuan, noArmada, idStok, kuantitas);
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
                    @"SELECT s.id_stok, s.id_ikan, s.id_ruang, s.kuantitas_kg,
                      i.nama_ikan, rc.nama_ruang, g.nama_gudang,
                      i.suhu_ideal, i.batas_suhu
                      FROM public.stok s
                      JOIN public.ikan i ON s.id_ikan = i.id_ikan
                      JOIN public.ruang_cooler rc ON s.id_ruang = rc.id_ruang
                      JOIN public.gudang g ON rc.id_gudang = g.id_gudang
                      ORDER BY s.id_stok", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
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
            return list;
        }
    }
}