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
   
    [Route("api/[controller]")]
    [ApiController]
    public class NoviController : ControllerBase
    {
        private readonly IUslugeService _recommenderSystem;

        public NoviController(IUslugeService recommenderSystem)
        {
            _recommenderSystem = recommenderSystem;
        }

       
    }
}