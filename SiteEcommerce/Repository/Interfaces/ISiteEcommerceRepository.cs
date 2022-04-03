using Repository.Entidades;
using System;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface ISiteEcommerceRepository
    {
        // SiteEcommerceEntity GetByProduto(string descricao, double valor);
        //object GetById(Guid id);
        SiteEcommerceEntity Patch(Guid id, bool situacao);
        List<SiteEcommerceEntity> GetCollection();
        //void Delete(object result);
    }
}
