using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
    public class ProizvodUpsertRequest
    {
        [Range(0,double.MaxValue)]
        public decimal Cijena { get; set; }
        public DateTime DatumKupovine { get; set; }

        [Range(0, int.MaxValue)]
        public int KolicinaUskladiste { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Sifra { get; set; }
        public byte[] Slika { get; set; }
        public int VrstaProizvodaId { get; set; }
    }
}
