using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Proizvods
    {
        public Proizvods()
        {
            ProizvodUsluga = new HashSet<ProizvodUsluga>();
        }

        public int ProizvodId { get; set; }
        public decimal Cijena { get; set; }
        public DateTime DatumKupovine { get; set; }
        public int KolicinaUskladiste { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int VrstaProizvodaId { get; set; }

        public virtual VrstaProizvoda VrstaProizvoda { get; set; }
        public virtual ICollection<ProizvodUsluga> ProizvodUsluga { get; set; }
    }
}
