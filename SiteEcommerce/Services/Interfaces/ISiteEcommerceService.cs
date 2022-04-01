using Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISiteEcommerceService
    {
        public (int, object) Insert(SiteEcommerceDto siteEcommerceDto);
        //public UsuarioRetornoDto GetById(Guid id);

        //public (int, object) Put(Guid id, UsuarioDto usuarioDto);

        //public (int, object) Patch(Guid id, UsuarioDto usuarioDto);

        //public (int, object) Delete(Guid id);
    }
}
