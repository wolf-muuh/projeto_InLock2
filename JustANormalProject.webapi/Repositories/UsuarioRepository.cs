using JustANormalProject.webapi.Contexts;
using JustANormalProject.webapi.Domains;
using JustANormalProject.webapi.Interfaces;
using JustANormalProject.webapi.Utils;
using Microsoft.AspNetCore.Http.HttpResults;

namespace JustANormalProject.webapi.Repositories
{
    public class UsuarioRepository : IUsuariosRepository
    {
        private readonly InLockContext ctx;
        public UsuarioRepository()
        {
            ctx = new InLockContext();
        }
        public Usuario BuscarUsuario(string email, string senha)
        {
            try
            {
                var usuarioBuscado = ctx.Usuario.FirstOrDefault(u => u.Email == email);
                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null;
            }
            catch (Exception e) 
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Usuario.Add(usuario);

                ctx.SaveChanges();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
