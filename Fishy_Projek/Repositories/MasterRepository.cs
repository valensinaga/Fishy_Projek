using System.Collections.Generic;
using Npgsql;
using Fishy_Projek.Models;

namespace Fishy_Projek.Repositories
{
    public class MasterRepository
    {
        public List<Ikan> GetAllIkan()
        {
            var list = new List<Ikan>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_ikan, nama_ikan, suhu_ideal, batas_suhu FROM public.ikan ORDER BY id_ikan", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new Ikan { IdIkan = reader.GetString(0), NamaIkan = reader.GetString(1), SuhuIdeal = reader.GetDouble(2), BatasSuhu = reader.GetDouble(3) });
            }
            return list;
        }

        public List<Gudang> GetAllGudang()
        {
            var list = new List<Gudang>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_gudang, nama_gudang, lokasi_gudang FROM public.gudang ORDER BY id_gudang", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new Gudang { IdGudang = reader.GetInt32(0), NamaGudang = reader.GetString(1), LokasiGudang = reader.GetString(2) });
            }
            return list;
        }

        public List<RuangCooler> GetAllRuang()
        {
            var list = new List<RuangCooler>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_ruang, id_gudang, nama_ruang, kapasitas_ton FROM public.ruang_cooler ORDER BY id_ruang", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new RuangCooler { IdRuang = reader.GetString(0), IdGudang = reader.GetInt32(1), NamaRuang = reader.GetString(2), KapasitasTon = reader.GetDouble(3) });
            }
            return list;
        }

        public void TambahIkan(Ikan ikan)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO public.ikan (id_ikan, nama_ikan, suhu_ideal, batas_suhu) VALUES (@id, @nama, @ideal, @batas)", conn);
                cmd.Parameters.AddWithValue("id", ikan.IdIkan);
                cmd.Parameters.AddWithValue("nama", ikan.NamaIkan);
                cmd.Parameters.AddWithValue("ideal", ikan.SuhuIdeal);
                cmd.Parameters.AddWithValue("batas", ikan.BatasSuhu);
                cmd.ExecuteNonQuery();
            }
        }
    }
}