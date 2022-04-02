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

        //[HttpPost]
        //public IActionResult Post([FromBody]SiteEcommerceDto siteEcommerceDto)
        //{
        //    var (statusCode, siteEcommerceRetornoDto) = _siteEcommerceService.Insert(siteEcommerceDto);

        //    return StatusCode(statusCode, siteEcommerceRetornoDto);
        //}

        [HttpGet("get")]
        public IActionResult Get(Guid id)
        {
            var resultado = _siteEcommerceService.GetById(id);

            if (resultado.Id == null)
            {
                return NotFound("Não existe registros salvos com o ID informado!");
            }

            return Ok(resultado);
        }
    }
}
