using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Model;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{

    public class UlogeController : BaseController<Model.Uloge, object>
    {
        public UlogeController(IService<Uloge, object> service) : base(service)
        {
        }
    }
}