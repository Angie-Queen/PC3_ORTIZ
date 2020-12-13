using Microsoft.EntityFrameworkCore;
using PC3_ORTIZ.Models;

namespace PC3_ORTIZ.Models
{
    public class WebAppContext : DbContext
    {
        public DbSet<Productos> Productos { get; set ;}
        public WebAppContext(DbContextOptions dco) : base(dco){

        }
    }
}