using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
   public class Zaposlenik
    {
        public int Id { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public  string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposelenja { get; set; }


        public string FullName
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }
        public int GradId { get; set;}
        public virtual ICollection<ZaposleniciUloge> ZaposleniciUloge { get; set; }
        
        public virtual Grad Grad { get; set; }
    }
}
