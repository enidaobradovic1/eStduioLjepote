using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Plata
    {
        public int Id { get; set; }
        public decimal Iznos { get; set; }
        public int ZaposlenikId { get; set; }
        public DateTime Datum { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }

        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
