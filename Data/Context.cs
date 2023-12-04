using BarSplitterMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BarSplitterMVC.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        { 
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Mesa> Mesa { get; set; }
        public DbSet<Jogo> Jogo { get; set;}
        public DbSet<Item> Item { get; set; }
        public DbSet<Grupo> Grupo { get; set; }    
    }
}
