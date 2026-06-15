using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class BatchMasuk
    {
        public string IdMasuk { get; set; }
        public int IdPihak { get; set; }
        public string IdIkan { get; set; }
        public string IdRuang { get; set; }
        public double KuantitasAwalKg { get; set; }
        public double SisaStokKg { get; set; }
        public DateTime WaktuMasuk { get; set; }
        public int IdUser { get; set; }

        public BatchMasuk(string idMasuk, int idPihak, string idIkan, string idRuang, double kuantitasAwalKg, double sisaStokKg, DateTime waktuMasuk, int idUser)
        {
            IdMasuk = idMasuk;
            IdPihak = idPihak;
            IdIkan = idIkan;
            IdRuang = idRuang;
            KuantitasAwalKg = kuantitasAwalKg;
            SisaStokKg = sisaStokKg;
            waktuMasuk = waktuMasuk;
            IdUser = idUser;
        }
    }
}
