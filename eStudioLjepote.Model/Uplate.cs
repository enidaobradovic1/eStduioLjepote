using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
    public class Uplate
    {
        public int Id { get; set; }
        public float Iznos { get; set; }
        public int RezervacijaId { get; set; }
        public int TipUplateId { get; set; }
        public DateTime DatumUplate { get; set; }
        public float Popust { get; set; }

    }
}
