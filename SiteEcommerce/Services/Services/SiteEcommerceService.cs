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

        public (int, object) GetCollection()
        {
            
            var listaEntidade = _siteEcommerceRepository.GetCollection();

            if (!listaEntidade.Any())
            {
                return ((int)EnumRetornoHttp.NotFound, new MensagemRetornoDto("Nenhum produto encontrado."));
            }

            List<RetornoDto> listaRetornoDto = new List<RetornoDto>();

            foreach (var item in listaEntidade)
            {
                listaRetornoDto.Add(RetornoDto.DeSiteEcommerceEntityParaRetornoDto(item));
            }

            return ((int)EnumRetornoHttp.Ok, listaRetornoDto);
        }

    }
}
