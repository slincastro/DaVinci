using System;
using System.Collections.Generic;
using DaVinci.WebAPI.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DaVinci.WebAPI.Controllers
{
    [Route("api/[]")]
    public class SystemComponentController : Controller
    {
        public IActionResult Get()
        {
            var systemComponents = new List<SystemComponent>
            {
                new SystemComponent("component1", "happy component 1"),
                new SystemComponent("component2", "happy component 2"),
                new SystemComponent("component3", "happy component 3")
            };
            return new OkObjectResult(systemComponents);
        }
    }
}