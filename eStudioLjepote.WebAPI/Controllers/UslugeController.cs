using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using eStudioLjepote.WebAPI.Database1;
using Microsoft.AspNetCore.Authorization;

namespace eStudioLjepote.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class UslugeController : ControllerBase
    {

       

        private readonly IUslugeService uslugeService;

        public UslugeController(IUslugeService uslugeService)
        {
            this.uslugeService = uslugeService;
        }

        [HttpGet]
        public List<Model.Usluga> Get()
        {
            
            return uslugeService.Get();
        }
        [HttpGet("{id}")]
        public Model.Usluga GetById(int id)
        {
            return uslugeService.GetById(id);
        }

        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public Model.Usluga Insert(UslugeUpsertRequest request)
        {
            return uslugeService.Insert(request);
        }
        [HttpPut("{Id}")]
        public Model.Usluga Update(int Id, [FromBody]UslugeUpsertRequest request)
        {
            return uslugeService.Update(Id, request);
        }
        [HttpGet("RecommendedUsluge/{id}")]
        public List<Usluga> RecommendedUsluge(int id)
        {


            List<Usluga> recommendedUsluge = uslugeService.GetRecommendedUsluge(id);
            


            return recommendedUsluge;
        }
    }
}