namespace Fishy_Projek.Models
{
    public class Stok
    {
        public int IdStok { get; set; }
        public string IdIkan { get; set; }
        public string IdRuang { get; set; }
        public double KuantitasKg { get; set; }
        public string NamaIkan { get; set; }
        public string NamaRuang { get; set; }
        public string NamaGudang { get; set; }
        public double SuhuIdeal { get; set; }
        public double BatasSuhu { get; set; }
    }
}