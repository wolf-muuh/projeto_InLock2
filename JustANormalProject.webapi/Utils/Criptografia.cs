using BCrypt.Net;

namespace JustANormalProject.webapi.Utils
{
    /// <summary>
    /// Gera uma hash a partir de uma senha
    /// </summary>
    public static class Criptografia
    {
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);

        }

        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);

        }
    }
}
