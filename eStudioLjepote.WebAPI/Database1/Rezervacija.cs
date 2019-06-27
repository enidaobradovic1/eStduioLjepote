using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            PruzeneUsluge = new HashSet<PruzeneUsluge>();
            Uplate = new HashSet<Uplate>();
        }

        public int Id { get; set; }
        public int BrojOsoba { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int KlijentId { get; set; }
        public bool Otkazano { get; set; }
        public bool Prihvaceno { get; set; }
        public int UslugeId { get; set; }
        public string Vrijeme { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Usluge Usluge { get; set; }
        public virtual ICollection<PruzeneUsluge> PruzeneUsluge { get; set; }
        public virtual ICollection<Uplate> Uplate { get; set; }
    }
}
