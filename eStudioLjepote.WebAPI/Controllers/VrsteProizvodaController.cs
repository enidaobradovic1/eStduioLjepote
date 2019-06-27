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

    public class VrsteProizvodaController : BaseController<Model.VrsteProizvoda, object>
    {
        public VrsteProizvodaController(IService<VrsteProizvoda, object> service) : base(service)
        {
        }
    }
}