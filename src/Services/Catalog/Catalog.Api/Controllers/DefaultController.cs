﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        private readonly ILogger<DefaultController> _logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}
