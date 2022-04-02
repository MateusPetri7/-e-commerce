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
                    true
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    true
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    true
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false

                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10,
                    false
                )
            };
        }

        public SiteEcommerceEntity Patch(Guid id, bool situacao)
        {

            var entidade = ListaProdutosEntity.Find(x => x.Id == id);
            entidade.Situacao = situacao;

            return entidade;
        }
    }
}
