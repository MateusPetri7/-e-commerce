using Repository.Entidades;

namespace Repository.Interfaces
{
    public interface ISiteEcommerceRepository
    {
        SiteEcommerceEntity GetByProduto(string descricao, double valor);
    }
}
