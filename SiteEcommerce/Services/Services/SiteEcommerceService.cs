using Services.Interfaces;
using Services.Dto;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Services.Services
{
    public class SiteEcommerceService : ISiteEcommerceService
    {
        private readonly ISiteEcommerceRepository _siteEcommerceRepository;

        public SiteEcommerceService(ISiteEcommerceRepository siteEcommerceRepository)
        {
            _siteEcommerceRepository = siteEcommerceRepository;
        }

        public (int, object) Patch(Guid id, SiteEcommerceDto siteEcommerceDto)
        {
            var entidade = _siteEcommerceRepository.Patch(id, siteEcommerceDto.Situacao);

            if (entidade == null)
            {
                return ((int)EnumRetornoHttp.NotFound, new MensagemRetornoDto("Produto não encontrado."));
            }

            return ((int)EnumRetornoHttp.Ok, RetornoDto.DeSiteEcommerceEntityParaRetornoDto(entidade));
        }

        //public (int, object) Delete(Guid id)
        //{
        //    var result = _siteEcommerceRepository.GetById(id);

        //    if (result == null)
        //    {
        //        return ((int)EnumRetornoHttp.NotFound, new MensagemRetornoDto("Produto não encontrado."));
        //    }

        //    _siteEcommerceRepository.Delete(result);

        //    return ((int)EnumRetornoHttp.Ok, new MensagemRetornoDto("O produto foi removido do carrinho!"));
        //}


    }
}
