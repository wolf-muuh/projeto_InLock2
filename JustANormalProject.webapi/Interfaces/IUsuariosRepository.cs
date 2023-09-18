using JustANormalProject.webapi.Domains;

namespace JustANormalProject.webapi.Interfaces
{
    public interface IUsuariosRepository
    {
        Usuario BuscarUsuario(string email, string senha);

        void Cadastrar(Usuario usuario);
    }
}
