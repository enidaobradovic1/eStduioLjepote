using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
    public class UplateUpsertRequest
    {

        [Required]
        public float Iznos { get; set; }
        public int RezervacijaId { get; set; }
        public int TipUplateId { get; set; }
        public DateTime DatumUplate { get; set; }
        public int ZaposlenikId { get; set; }

        [Required]
        public float Popust { get; set; }
    }
}
