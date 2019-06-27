using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class RezervacijaEdukacije
    {
        public int Id { get; set; }
        public int EdukacijaId { get; set; }
        public int KlijentId { get; set; }
        public int ZaposlenikId { get; set; }

        public virtual Edukacija Edukacija { get; set; }
        public virtual Klijent Klijent { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
