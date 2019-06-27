using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{
   
    public class GradoviController : BaseController<Model.Grad, object>
    {
        public GradoviController(IService<Grad, object> service) : base(service)
        {
        }
    }
}