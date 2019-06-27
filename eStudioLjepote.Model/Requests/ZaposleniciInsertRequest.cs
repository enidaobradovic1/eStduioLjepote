using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace eStudioLjepote.Model.Requests
{
   public class ZaposleniciInsertRequest
    {
        [Required]
        public string BrojTelefona { get; set; }
       
        public DateTime DatumRodjenja { get; set; }
        
        public DateTime DatumZaposelenja { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        public string Ime { get; set; }
        [Required]
        [MinLength(4)]
        public string Prezime { get; set; }
        [Required]
        public string Jmbg { get; set; }
        public double? TekuciRacun { get; set; }
        [Required]
        [MinLength(4)]
        public string Username { get; set; }

        public List<int> Uloge { get; set; } = new List<int>();

        public int GradId { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        
    }
}
