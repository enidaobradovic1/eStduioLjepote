using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Uplate
    {
        public int Id { get; set; }
        public float Iznos { get; set; }
        public int RezervacijaId { get; set; }
        public int TipUplateId { get; set; }
        public int ZaposlenikId { get; set; }
        public DateTime DatumUplate { get; set; }
        public float Popust { get; set; }

        public virtual Rezervacija Rezervacija { get; set; }
        public virtual TipUplate TipUplate { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
