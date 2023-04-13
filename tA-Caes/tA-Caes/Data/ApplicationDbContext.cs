using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tA_Caes.Models;

namespace tA_Caes.Data
{
    /// <summary>
    /// esta classe representa a BD do projeto
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*
         * Criação das tabelas da BD
         */
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Animais> Animais { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Fotografias> Fotografias { get;set; }
    }
}