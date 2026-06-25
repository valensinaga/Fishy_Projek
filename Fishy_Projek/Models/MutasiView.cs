using System;

namespace Fishy_Projek.Models
{
    public class MutasiView 
    {
        
        public string KodeBatchMasuk { get; set; }
        public string NamaIkan { get; set; }
        public string PenyuplaiNelayan { get; set; }
        public DateTime WaktuMasuk { get; set; }
        public double KuantitasAwalKg { get; set; }
        public double SisaStokKg { get; set; }

      
        public string SuratJalanKeluar { get; set; }
        public string TujuanDistribusi { get; set; }
        public double? KuantitasKeluarKg { get; set; }
        public DateTime? WaktuKeluar { get; set; }
    }

}