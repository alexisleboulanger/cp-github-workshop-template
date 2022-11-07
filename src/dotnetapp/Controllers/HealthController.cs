using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "OK";
        }

        [HttpGet]
        [Route("startup")]
        public string GetStartup()
        {
            return "Started";
        }

        [HttpGet]
        [Route("ready")]
        public string GetReady()
        {
            return "Ready";
        }

        [HttpGet]
        [Route("error")]
        public string GetError()
        {
            if (DateTime.Now.Second > 30) {
                throw new Exception("Server error.");
            }
            return "working";
        }
    }
}
