using System;

namespace Fishy_Projek.Models
{
    public class MutasiView
    {
        public string IdTransaksi { get; set; }
        public string NamaIkan { get; set; }
        public string NamaRuang { get; set; }
        public string JenisMutasi { get; set; }
        public double JumlahKg { get; set; }
        public DateTime WaktuTransaksi { get; set; }
        public string NamaOperator { get; set; }
        public string AsalTujuan { get; set; } // Nama Nelayan atau UMKM
    }
}