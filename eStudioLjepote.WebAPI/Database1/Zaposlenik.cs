using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Zaposlenik
    {
        public Zaposlenik()
        {
            Plata = new HashSet<Plata>();
            PruzeneUsluge = new HashSet<PruzeneUsluge>();
            RezervacijaEdukacije = new HashSet<RezervacijaEdukacije>();
            Uplate = new HashSet<Uplate>();
            ZaposleniciUloge = new HashSet<ZaposleniciUloge>();
        }

        public int Id { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposelenja { get; set; }
        public string Email { get; set; }
        public int GradId { get; set; }
        public string Ime { get; set; }
        public string Jmbg { get; set; }
        public string PasswordSalt { get; set; }
        public string PaswordHash { get; set; }
        public string Prezime { get; set; }
        public double? TekuciRacun { get; set; }
        public string Username { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Plata> Plata { get; set; }
        public virtual ICollection<PruzeneUsluge> PruzeneUsluge { get; set; }
        public virtual ICollection<RezervacijaEdukacije> RezervacijaEdukacije { get; set; }
        public virtual ICollection<Uplate> Uplate { get; set; }
        public virtual ICollection<ZaposleniciUloge> ZaposleniciUloge { get; set; }
    }
}
