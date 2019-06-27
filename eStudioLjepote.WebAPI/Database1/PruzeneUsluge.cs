using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class PruzeneUsluge
    {
        public int Id { get; set; }
        public int RezervacijaId { get; set; }
        public int UslugaId { get; set; }
        public int ZaposlenikId { get; set; }

        public virtual Rezervacija Rezervacija { get; set; }
        public virtual Usluge Usluga { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
