using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
    public class Proizvod
    {
        public int ProizvodId { get; set; }
        public decimal Cijena { get; set; }
        public DateTime DatumKupovine { get; set; }
        public int KolicinaUskladiste { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public byte[] Slika { get; set; }

        public int VrstaProizvodaId { get; set; }
    }
}
