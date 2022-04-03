using Repository.Interfaces;
using Repository.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositorios
{
    public class SiteEcommerceRepository : ISiteEcommerceRepository
    {
        public List<SiteEcommerceEntity> ListaProdutosEntity;

        public SiteEcommerceRepository()
        {
            ListaProdutosEntity = new List<SiteEcommerceEntity>()
            {
                new SiteEcommerceEntity
                (
                    "Smart TV LG 43, 4K com WiFi e Bluetooth",
                    2399.00,
                    true,
                    ".images/image01"
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    true,
                    ".images/image02"
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    true,
                    ".images/image03"
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false,
                    ".images/image04"

                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false,
                    ".images/image05"
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false,
                    ".images/image06"
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false,
                    ".images/image07"
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false,
                    ".images/image08"
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false,
                    ".images/image09"
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false,
                    ".images/image010"
                ),
            };
        }

        public SiteEcommerceEntity Patch(Guid id, bool situacao)
        {

            var entidade = ListaProdutosEntity.Find(x => x.Id == id);
            entidade.Situacao = situacao;

            return entidade;
        }

        public List<SiteEcommerceEntity> GetCollection()
        {
            return ListaProdutosEntity;
        }
    }
}
