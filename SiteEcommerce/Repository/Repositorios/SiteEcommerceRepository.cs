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
                    2399.00
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                 new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                ),
                new SiteEcommerceEntity
                (
                    "Celular",
                    0.10
                )
            };
        }

        public SiteEcommerceEntity GetByProduto(string descricao, double valor)
        {

            var entidade = ListaProdutosEntity.Find(x => x.Descricao == descricao && x.Valor == valor);

            return entidade;
        }
    }
}
