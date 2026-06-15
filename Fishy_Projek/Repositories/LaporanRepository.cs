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

        public List<MutasiView> GetRiwayatMutasi(string filter)
        {
            var list = new List<MutasiView>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = filter == "SEMUA"
                    ? @"SELECT m.id_mutasi, m.id_stok, m.jenis_mutasi, m.kuantitas_mutasi, m.waktu_mutasi,
                        i.nama_ikan, rc.nama_ruang, g.nama_gudang
                        FROM public.mutasi_stok m
                        JOIN public.stok s ON m.id_stok = s.id_stok
                        JOIN public.ikan i ON s.id_ikan = i.id_ikan
                        JOIN public.ruang_cooler rc ON s.id_ruang = rc.id_ruang
                        JOIN public.gudang g ON rc.id_gudang = g.id_gudang
                        ORDER BY m.waktu_mutasi DESC"
                    : @"SELECT m.id_mutasi, m.id_stok, m.jenis_mutasi, m.kuantitas_mutasi, m.waktu_mutasi,
                        i.nama_ikan, rc.nama_ruang, g.nama_gudang
                        FROM public.mutasi_stok m
                        JOIN public.stok s ON m.id_stok = s.id_stok
                        JOIN public.ikan i ON s.id_ikan = i.id_ikan
                        JOIN public.ruang_cooler rc ON s.id_ruang = rc.id_ruang
                        JOIN public.gudang g ON rc.id_gudang = g.id_gudang
                        WHERE m.jenis_mutasi = @filter
                        ORDER BY m.waktu_mutasi DESC";
                var cmd = new NpgsqlCommand(query, conn);
                if (filter != "SEMUA") cmd.Parameters.AddWithValue("filter", filter);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new MutasiView
                    {
                        IdMutasi = reader.GetInt32(0),
                        IdStok = reader.GetInt32(1),
                        JenisMutasi = reader.GetString(2),
                        JumlahKg = reader.GetDouble(3),
                        WaktuMutasi = reader.GetDateTime(4),
                        NamaIkan = reader.GetString(5),
                        NamaRuang = reader.GetString(6),
                        NamaGudang = reader.GetString(7)
                    });
            }
            return list;
        }
    }
}