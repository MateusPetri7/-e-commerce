using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Dto;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteEcommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiteEcommerceController : ControllerBase
    {

        private readonly ISiteEcommerceService _siteEcommerceService;

        public SiteEcommerceController(ISiteEcommerceService siteEcommerceService)
        {
            _siteEcommerceService = siteEcommerceService;
        }

        [HttpPatch("patch")]
        public IActionResult Patch(Guid id, [FromBody]SiteEcommerceDto siteEcommerceDto)
        {
            var resultado = _siteEcommerceService.Patch(id, siteEcommerceDto);

            return Ok(resultado);
        }

        [HttpGet("getcollection")]
        public IActionResult GetCollection()
        {
            var resultado = _siteEcommerceService.GetCollection();

            return Ok(resultado);
        }
    }
}
