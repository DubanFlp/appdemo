using Microsoft.EntityFrameworkCore;

namespace App.Api.Modelos
{
    public class UdiDbContext : DbContext{

        public UdiDbContext(DbContextOptions<UdiDbContext> opts) : base(opts)
        {
            Database.EnsureCreated(); 
        }
        public DbSet<Curso> cursos {get;set;}
        public DbSet<Estudiante> estudiantes {get;set;}
        public DbSet<Profesor> profesores {get;set;}
        public DbSet<Escuela> escuelas {get;set;}

        protected override void OnModelCreating(ModelBuilder builder){
    
        }
    }
}
