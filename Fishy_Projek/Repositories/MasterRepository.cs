using System;
using System.Collections.Generic;
using Npgsql;
using Fishy_Projek.Models;
using Fishy_Projek.Helpers;
using System.Data;

namespace Fishy_Projek.Repositories
{
    public class MasterRepository
    {
        // ==========================================
        // MASTER IKAN
        // ==========================================
        public List<Ikan> GetAllIkan()
        {
            var list = new List<Ikan>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_ikan, nama_ikan, suhu_ideal, batas_suhu FROM ikan ORDER BY id_ikan", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new Ikan { IdIkan = reader.GetString(0), NamaIkan = reader.GetString(1), SuhuIdeal = reader.GetDouble(2), BatasSuhu = reader.GetDouble(3) });
            }
            return list;
        }

        public void TambahIkan(Ikan ikan)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO ikan (id_ikan, nama_ikan, suhu_ideal, batas_suhu) VALUES (@id, @nama, @ideal, @batas)", conn);
                cmd.Parameters.AddWithValue("id", ikan.IdIkan);
                cmd.Parameters.AddWithValue("nama", ikan.NamaIkan);
                cmd.Parameters.AddWithValue("ideal", ikan.SuhuIdeal);
                cmd.Parameters.AddWithValue("batas", ikan.BatasSuhu);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateIkan(string id, string nama, double ideal, double batas)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE ikan SET nama_ikan = @nama, suhu_ideal = @ideal, batas_suhu = @batas WHERE id_ikan = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("ideal", ideal);
                cmd.Parameters.AddWithValue("batas", batas);
                cmd.ExecuteNonQuery();
            }
        }

       

        // ==========================================
        // MASTER GUDANG
        // ==========================================
        public List<Gudang> GetAllGudang()
        {
            var list = new List<Gudang>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_gudang, nama_gudang, lokasi_gudang FROM gudang ORDER BY id_gudang", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new Gudang { IdGudang = reader.GetInt32(0), NamaGudang = reader.GetString(1), LokasiGudang = reader.GetString(2) });
            }
            return list;
        }

        public void TambahGudang(int id, string nama, string lokasi)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO gudang (id_gudang, nama_gudang, lokasi_gudang) VALUES (@id, @nama, @lokasi)", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("lokasi", lokasi);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateGudang(int id, string nama, string lokasi)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE gudang SET nama_gudang = @nama, lokasi_gudang = @lokasi WHERE id_gudang = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("lokasi", lokasi);
                cmd.ExecuteNonQuery();
            }
        }

        public void HapusGudang(int id)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM gudang WHERE id_gudang = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ==========================================
        // MASTER RUANG COOLER
        // ==========================================
        public List<RuangCooler> GetAllRuang()
        {
            var list = new List<RuangCooler>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_ruang, id_gudang, nama_ruang, kapasitas_kg FROM ruang_cooler ORDER BY id_ruang", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RuangCooler
                    {
                        IdRuang = reader.GetString(0),
                        IdGudang = reader.GetInt32(1),
                        NamaRuang = reader.GetString(2),
                        KapasitasKg = reader.GetDouble(3)
                    });
                }
            }
            return list;
        }

        public void TambahRuang(string idRuang, int idGudang, string namaRuang, double kapasitas)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO ruang_cooler (id_ruang, id_gudang, nama_ruang, kapasitas_kg) VALUES (@idRuang, @idGudang, @nama, @kapasitas)", conn);
                cmd.Parameters.AddWithValue("idRuang", idRuang);
                cmd.Parameters.AddWithValue("idGudang", idGudang);
                cmd.Parameters.AddWithValue("nama", namaRuang);
                cmd.Parameters.AddWithValue("kapasitas", kapasitas);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRuang(string idRuang, int idGudang, string namaRuang, double kapasitas)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE ruang_cooler SET id_gudang = @idGudang, nama_ruang = @nama, kapasitas_kg = @kapasitas WHERE id_ruang = @idRuang", conn);
                cmd.Parameters.AddWithValue("idRuang", idRuang);
                cmd.Parameters.AddWithValue("idGudang", idGudang);
                cmd.Parameters.AddWithValue("nama", namaRuang);
                cmd.Parameters.AddWithValue("kapasitas", kapasitas);
                cmd.ExecuteNonQuery();
            }
        }

        public void HapusRuang(string idRuang)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM ruang_cooler WHERE id_ruang = @idRuang", conn);
                cmd.Parameters.AddWithValue("idRuang", idRuang);
                cmd.ExecuteNonQuery();
            }
        }

        // ==========================================
        // MASTER USER / OPERATOR (Tabel "user")
        // ==========================================
        public List<Operator> GetAllUser()
        {
            var list = new List<Operator>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                // Menggunakan "user" dengan tanda kutip agar tidak error syntax reserved keyword
                var cmd = new NpgsqlCommand("SELECT id_user, nama, username, password, id_role FROM users ORDER BY id_user", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Operator
                    {
                        IdUser = reader.GetInt32(0),
                        Nama = reader.GetString(1),
                        Username = reader.GetString(2),
                        Password = reader.GetString(3),
                        IdRole = reader.GetInt32(4)
                    });
                }
            }
            return list;
        }

        public void TambahUser(int idUser, string nama, string username, string password, int idRole)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO users(id_user, nama, username, password, id_role) VALUES (@id, @nama, @username, @password, @role)", conn);
                cmd.Parameters.AddWithValue("id", idUser);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("role", idRole);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(int idUser, string nama, string username, string password, int idRole)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE users SET nama = @nama, username = @username, password = @password, id_role = @role WHERE id_user = @id", conn);
                cmd.Parameters.AddWithValue("id", idUser);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("role", idRole);
                cmd.ExecuteNonQuery();
            }
        }

        public void HapusUser(int idUser)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM users WHERE id_user = @id", conn);
                cmd.Parameters.AddWithValue("id", idUser);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetRolesDataTable()
        {
            var dt = new DataTable();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                // Ambil langsung dari tabel roles
                var cmd = new NpgsqlCommand("SELECT id_role, nama_role FROM roles ORDER BY id_role", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    // Load hasil query SQL langsung ke dalam DataTable
                    dt.Load(reader);
                }
            }
            return dt;
        }

    }
}