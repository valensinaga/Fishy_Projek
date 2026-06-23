using System;
using Npgsql;
using Fishy_Projek.Models;
using Fishy_Projek.Repositories;

namespace Fishy_Projek.Controllers
{
    public class OperasionalController
    {
        private OperasionalRepository _repo = new OperasionalRepository();

        public void SimpanLogHarian(string idRuang, double suhu, string grade, string catatan)
        {
            BatchIkan b = new BatchIkan { IdRuang = idRuang, SuhuAktualC = suhu, GradeMutu = grade, Catatan = catatan };
            _repo.SimpanBatchIkan(b);
        }

        public void ProsesIkanMasuk(string idMasuk, string idIkan, int idPihak, string idRuang, double kuantitasMasuk, int idUser)
        {
            _repo.EksekusiStoredProcedureTerimaStok(idMasuk, idIkan, idPihak, idRuang, kuantitasMasuk, idUser);
        }

        public bool ProsesKirimBarang(string idPengiriman, string idMasuk, int idPihak, string noArmada, double kuantitasKirim, int idUser, out string statusNotifikasi)
        {
            try
            {
                _repo.EksekusiStoredProcedurePengiriman(idPengiriman, idMasuk, idPihak, noArmada, kuantitasKirim, idUser);
                statusNotifikasi = "Sukses! Pengiriman berhasil diproses.";
                return true;
            }
            catch (PostgresException ex) when (ex.SqlState == "P0001")
            {
                statusNotifikasi = "Transaksi Ditolak: " + ex.MessageText;
                return false;
            }
            catch (Exception ex)
            {
                statusNotifikasi = "Gagal: " + ex.Message;
                return false;
            }
        }
    }
}