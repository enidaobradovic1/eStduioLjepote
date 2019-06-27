using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Edukacija
    {
        public Edukacija()
        {
            RezervacijaEdukacije = new HashSet<RezervacijaEdukacije>();
        }

        public int Id { get; set; }
        public float Cijena { get; set; }
        public DateTime Kraj { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime Pocetak { get; set; }

        public virtual ICollection<RezervacijaEdukacije> RezervacijaEdukacije { get; set; }
    }
}
