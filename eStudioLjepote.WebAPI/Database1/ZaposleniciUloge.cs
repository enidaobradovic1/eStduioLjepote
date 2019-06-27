using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class ZaposleniciUloge
    {
        public int Id { get; set; }
        public int UlogaId { get; set; }
        public int ZaposlenikId { get; set; }

        public virtual Uloge Uloga { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
