using Microsoft.EntityFrameworkCore;
using WebMvcMySql.Models;

namespace WebMvcMySql.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :base(options) 
        {

        }
        
        public DbSet<Usuario> Usuario { get; set; }


                 
        

    }
}
