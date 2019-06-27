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

    public class ProizvodiController : BaseCRUDController<Model.Proizvod, ProizvodSearchRequest, ProizvodUpsertRequest, ProizvodUpsertRequest>
    {
        public ProizvodiController(ICRUDService<Proizvod, ProizvodSearchRequest, ProizvodUpsertRequest, ProizvodUpsertRequest> service) : base(service)
        {
        }
    }
}