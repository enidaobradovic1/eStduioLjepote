using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Klijent
    {
        public Klijent()
        {
            Ratings = new HashSet<Ratings>();
            Rezervacija = new HashSet<Rezervacija>();
            RezervacijaEdukacije = new HashSet<RezervacijaEdukacije>();
        }

        public int Id { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public int GradId { get; set; }
        public string Ime { get; set; }
        public string PasswordSalt { get; set; }
        public string PaswordHash { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string Username { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
        public virtual ICollection<RezervacijaEdukacije> RezervacijaEdukacije { get; set; }
    }
}
