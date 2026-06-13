using System;

namespace Fishy_Projek.Models
{
    public class BatchIkan
    {
        public int IdBatch { get; set; }
        public string IdRuang { get; set; }
        public DateTime WaktuCek { get; set; }
        public double SuhuAktualC { get; set; }
        public string GradeMutu { get; set; }
        public string Catatan { get; set; }
        public int IdUser { get; set; }
    }
}