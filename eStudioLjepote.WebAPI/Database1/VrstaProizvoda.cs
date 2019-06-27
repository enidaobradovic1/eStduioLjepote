using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class VrstaProizvoda
    {
        public VrstaProizvoda()
        {
            Proizvods = new HashSet<Proizvods>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvods> Proizvods { get; set; }
    }
}
