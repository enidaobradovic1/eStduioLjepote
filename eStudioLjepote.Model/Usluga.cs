using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
    public class Usluga
    {
        public int Id { get; set; }
        public float Cijena { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }

    }
}
