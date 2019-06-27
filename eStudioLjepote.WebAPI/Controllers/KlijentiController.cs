using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{


    

    public class KlijentiController : BaseCRUDController<Model.Klijent, KlijentiSearchRequest, KlijentiUpsertRequest, KlijentiUpsertRequest>
    {
        public KlijentiController(ICRUDService<Klijent, KlijentiSearchRequest, KlijentiUpsertRequest, KlijentiUpsertRequest> service) : base(service)
        {
        }
    }
}