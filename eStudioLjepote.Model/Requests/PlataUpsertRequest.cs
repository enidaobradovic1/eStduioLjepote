using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
    public  class PlataUpsertRequest
    {

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Iznos { get; set; }
        public int ZaposlenikId { get; set; }
        public DateTime Datum { get; set; }
        [Required]
     
        public int Godina { get; set; }
        [Required]
        
        public int Mjesec { get; set; }
    }
}
