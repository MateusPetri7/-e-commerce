using Repository.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dto
{
    public class RetornoDto : SiteEcommerceBaseDto
    {
        public Guid Id { get; set; }

        public static RetornoDto DeSiteEcommerceEntityParaRetornoDto(SiteEcommerceEntity siteEcommerceEntity)
        {
            return new RetornoDto
            {
                Id = siteEcommerceEntity.Id,
                Descricao = siteEcommerceEntity.Descricao,
                Valor = siteEcommerceEntity.Valor,
                Situacao = siteEcommerceEntity.Situacao,
                Imagem = siteEcommerceEntity.Imagem
            };
        }
    }
}
