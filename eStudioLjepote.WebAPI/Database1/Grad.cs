using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Grad
    {
        public Grad()
        {
            Klijent = new HashSet<Klijent>();
            Zaposlenik = new HashSet<Zaposlenik>();
        }

        public int Id { get; set; }
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Klijent> Klijent { get; set; }
        public virtual ICollection<Zaposlenik> Zaposlenik { get; set; }
    }
}
