using Repository.Entidades;
using System;

namespace Repository.Interfaces
{
    public interface ISiteEcommerceRepository
    {
        // SiteEcommerceEntity GetByProduto(string descricao, double valor);
        //object GetById(Guid id);
        SiteEcommerceEntity Patch(Guid id, bool situacao);
        //void Delete(object result);
    }
}
