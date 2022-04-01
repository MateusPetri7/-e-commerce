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

        public (int, object) Insert(SiteEcommerceDto siteEcommerceDto)
        {
            if (siteEcommerceDto.Descricao == "" || siteEcommerceDto.Valor == 0);
            {
                return ((int)EnumRetornoHttp.Ok, new MensagemRetornoDto("Todos os dados devem ser preenchidos."));
            }

            var entidade = _siteEcommerceRepository.GetByProduto(siteEcommerceDto.Descricao, siteEcommerceDto.Valor);

            if (entidade == null)
            {
                return ((int)EnumRetornoHttp.Ok, new MensagemRetornoDto("Usuário não encontrado."));
            }

            return ((int)EnumRetornoHttp.Ok, RetornoDto.DeSiteEcommerceEntityParaRetornoDto(entidade));
        }

        //public (int, object) Put(Guid id, UsuarioDto usuarioDto)
        //{
        //    var result = _usuarioRepository.GetById(id);

        //    if (result == null)
        //    {
        //        return ((int)EnumRetornosHttp.NotFound, new MensagemRetornoDto("Usuário não encontrado."));
        //    }

        //    if ((usuarioDto.Nome == result.Nome || usuarioDto.Login == result.Login || usuarioDto.Senha == result.Senha) &&
        //        (usuarioDto.Nome == "" || usuarioDto.Login == "" || usuarioDto.Senha == ""))

        //    {
        //        return ((int)EnumRetornosHttp.BadRequest, new MensagemRetornoDto("Todos os dados devem ser preenchidos e nenhum deve ser igual ao que já era antes."));
        //    }

        //    result.Nome = usuarioDto.Nome;
        //    result.Login = usuarioDto.Login;
        //    result.Senha = usuarioDto.Senha;

        //    return ((int)EnumRetornosHttp.Ok, UsuarioRetornoDto.DeUsuarioEntityParaUsuarioRetornoDto(result));
        //}

        //public (int, object) Patch(Guid id, UsuarioDto usuarioDto)
        //{
        //    var result = _usuarioRepository.GetById(id);

        //    if (result == null)
        //    {
        //        return ((int)EnumRetornosHttp.NotFound, new MensagemRetornoDto("Usuário não encontrado."));
        //    }

        //    if ((usuarioDto.Nome != result.Nome && usuarioDto.Login != result.Login && usuarioDto.Senha != result.Senha) ||
        //        (usuarioDto.Nome == result.Nome && usuarioDto.Login == result.Login && usuarioDto.Senha == result.Senha))
        //    {
        //        return ((int)EnumRetornosHttp.BadRequest, new MensagemRetornoDto("Somente alguns dados devem ser preenchidos, não todos."));
        //    }

        //    if (usuarioDto.Nome != result.Nome)
        //    {
        //        result.Nome = usuarioDto.Nome;
        //    }
        //    if (usuarioDto.Senha != result.Senha)
        //    {
        //        result.Senha = usuarioDto.Senha;
        //    }
        //    if (usuarioDto.Login != result.Login)
        //    {
        //        result.Login = usuarioDto.Login;
        //    }

        //    return ((int)EnumRetornosHttp.Ok, UsuarioRetornoDto.DeUsuarioEntityParaUsuarioRetornoDto(result));
        //}

        //public (int, object) Delete(Guid id)
        //{
        //    var result = _usuarioRepository.GetById(id);

        //    if (result == null)
        //    {
        //        return ((int)EnumRetornosHttp.NotFound, new MensagemRetornoDto("Usuário não encontrado."));
        //    }

        //    _usuarioRepository.Delete(result);

        //    return ((int)EnumRetornosHttp.Ok, new MensagemRetornoDto("Usuário deletado."));
        //}
    }
}
