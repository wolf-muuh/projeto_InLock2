using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustANormalProject.webapi.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuarios
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O tipo do usuario é obrigatório")]
        public string? Titulo { get; set; }

    }
}
