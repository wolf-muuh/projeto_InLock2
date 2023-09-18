using JustANormalProject.webapi.Domains;
using Microsoft.EntityFrameworkCore;

namespace JustANormalProject.webapi.Contexts
{
    public class InLockContext : DbContext
    {
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; } 

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE17-S15; Database = inlock_games_codeFirst_tarde; User Id= sa; Pwd = Senai@134; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
