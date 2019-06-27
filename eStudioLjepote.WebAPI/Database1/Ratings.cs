using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database1
{
    public partial class Ratings
    {
        public int RatingId { get; set; }
        public int KlijentId { get; set; }
        public int Rating1 { get; set; }
        public int UslugeId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Usluge Usluge { get; set; }
    }
}
