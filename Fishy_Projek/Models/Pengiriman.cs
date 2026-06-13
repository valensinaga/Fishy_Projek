using System;

namespace Fishy_Projek.Models
{
    public class Pengiriman
    {
        public string IdPengiriman { get; set; }
        public int IdUser { get; set; }
        public DateTime WaktuKirim { get; set; }
        public string Tujuan { get; set; }
        public string NoArmada { get; set; }
    }
}