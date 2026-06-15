using System;

namespace Fishy_Projek.Models
{
    public class PihakEksternal
    {
        public int IdPihak { get; set; }
        public string NamePihak { get; set; }
        public string Peran { get; set; }
        public string Kontak { get; set; }

        public PihakEksternal(int idPihak, string namePihak, string peran, string kontak)
        {
            IdPihak = idPihak;
            NamePihak = namePihak;
            Peran = peran;
            Kontak = kontak;
        }
    }
}
