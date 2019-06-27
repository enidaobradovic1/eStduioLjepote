using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{

    public class RezervacijaController : BaseCRUDController<Model.Rezervacija, RezervacijeSearchRequest, RezervacijaInsertRequest, RezervacijeUpdateRequest>
    {
        public RezervacijaController(ICRUDService<Rezervacija, RezervacijeSearchRequest, RezervacijaInsertRequest, RezervacijeUpdateRequest> service) : base(service)
        {
        }
    }
}