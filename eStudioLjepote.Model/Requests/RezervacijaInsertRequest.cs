using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
    public  class RezervacijaInsertRequest
    {
        public int BrojOsoba { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int KlijentId { get; set; }
        public bool Otkazano { get; set; }
        public bool Prihvaceno { get; set; }
        public int UslugeId { get; set; }
        public string Vrijeme { get; set; }
    }
}
