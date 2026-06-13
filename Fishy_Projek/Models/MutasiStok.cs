using System;

namespace Fishy_Projek.Models
{
    public class MutasiStok
    {
        public int IdMutasi { get; set; }
        public int IdStok { get; set; }
        public string JenisMutasi { get; set; }
        public double JumlahKg { get; set; }
        public int IdUser { get; set; }
        public DateTime WaktuMutasi { get; set; }
        public string NamaOperator { get; set; }
        public string NamaIkan { get; set; }
        public string NamaRuang { get; set; }
        public string NamaGudang { get; set; }
    }
}