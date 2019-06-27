using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{

   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]

    public class ZaposleniciController : ControllerBase
    {
        private readonly IZaposleniciService zaposleniciService;

        public ZaposleniciController(IZaposleniciService zaposleniciService)
        {
            this.zaposleniciService = zaposleniciService;
        }
        [HttpGet]
        public List<Model.Zaposlenik>Get([FromQuery]ZaposleniciSearchRequest request)
        {
            Thread.Sleep(5000);
            return zaposleniciService.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Zaposlenik GetById(int id)
        {
            return zaposleniciService.GetById(id);
        }

        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public Model.Zaposlenik Insert(ZaposleniciInsertRequest request)
        {
            return zaposleniciService.Insert(request);
        }
       [HttpPut("{Id}")]
        public Model.Zaposlenik Update(int Id,[FromBody]ZaposleniciInsertRequest request)
        {
            return zaposleniciService.Update(Id,request);
        }
    }
}