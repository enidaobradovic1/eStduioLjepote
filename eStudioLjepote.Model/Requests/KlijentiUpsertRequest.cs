using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
    public class KlijentiUpsertRequest
    {
        [Required]
       
        public string BrojTelefona { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int GradId { get; set; }
        [Required]
        [MinLength(4)]
        public string Ime { get; set; }
        
        public string Password { get; set; }

        public string PasswordConfirmation { get; set; }
        [Required]
        [MinLength(4)]
        public string Prezime { get; set; }
        public string Spol { get; set; }
        [Required]
        [MinLength(4)]
        public string Username { get; set; }
    }
}
