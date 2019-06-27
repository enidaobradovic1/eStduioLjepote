using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
    public  class Klijent
    {
        public int Id { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public int GradId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string Username { get; set; }
        public string PaswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
