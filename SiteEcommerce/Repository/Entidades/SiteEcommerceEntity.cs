using System;

namespace Repository.Entidades
{
    public class SiteEcommerceEntity : BaseEntity
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool Situacao { get; set; }

        public SiteEcommerceEntity(string descricao, double valor, bool situacao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Valor = valor;
            Situacao = situacao;
        }
    }
}
