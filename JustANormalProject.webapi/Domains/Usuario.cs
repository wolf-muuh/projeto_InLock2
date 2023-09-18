using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustANormalProject.webapi.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "O email é obrigatorio")]
        
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha é obrigatoria")]
        [StringLength(60, MinimumLength =  6, ErrorMessage = "Senha de 6 a 60 caracteres!")]
        public string? Senha { get; set; }

        //ref. tabela TiposUsuario

        [Required(ErrorMessage = "Tipo do usuario obrigatório")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuarios? TiposUsuarios { get; set; }

    }
}
