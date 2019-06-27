using AutoMapper;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database1.Zaposlenik, Model.Zaposlenik>();
            CreateMap<Database1.Zaposlenik, ZaposleniciInsertRequest>().ReverseMap();
            CreateMap<Database1.Grad, Model.Grad>();
            CreateMap<Database1.VrstaProizvoda, Model.VrsteProizvoda>();
            CreateMap<Database1.Proizvods, ProizvodUpsertRequest>().ReverseMap();
            CreateMap<Database1.Klijent, KlijentiUpsertRequest>().ReverseMap();
            CreateMap<Database1.Usluge, UslugeUpsertRequest>().ReverseMap();
            CreateMap<Database1.Uplate, UplateUpsertRequest>().ReverseMap();
            CreateMap<Database1.Rezervacija, Model.Rezervacija>().ReverseMap();
            CreateMap<Database1.Rezervacija, RezervacijeUpdateRequest>().ReverseMap();
            CreateMap<Database1.Rezervacija, RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Database1.Ratings, OcjeneUpsertRequest>().ReverseMap();

            CreateMap<Database1.Plata, PlataUpsertRequest>().ReverseMap();


        }
    }
}
