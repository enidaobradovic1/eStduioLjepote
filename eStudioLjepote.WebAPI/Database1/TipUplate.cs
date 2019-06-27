using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class TipUplate
    {
        public TipUplate()
        {
            Uplate = new HashSet<Uplate>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Uplate> Uplate { get; set; }
    }
}
