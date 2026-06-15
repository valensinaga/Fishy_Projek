using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class BatchKeluar
    {
        public string IdKeluar { get; set; }
        public string IdMasuk { get; set; }
        public int IdPihak { get; set; }
        public string IdIkan { get; set; }
        public string NoArmada { get; set; }
        public double KuantitasKeluar { get; set; }

        public BatchKeluar(string idKeluar, string idMasuk, int idPihak, string idIkan, string noArmada, double kuantitas)
        {
            IdKeluar = idKeluar;
            IdMasuk = idMasuk;
            IdPihak = idPihak;
            IdIkan = idIkan;
            NoArmada = noArmada;
            KuantitasKeluar = KuantitasKeluar;
        }
    }

  
}
