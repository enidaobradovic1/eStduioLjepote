using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class ProizvodUsluga
    {
        public int ProizvodUslugaId { get; set; }
        public int ProizvodId { get; set; }
        public int UslugeId { get; set; }

        public virtual Proizvods Proizvod { get; set; }
        public virtual Usluge Usluge { get; set; }
    }
}
