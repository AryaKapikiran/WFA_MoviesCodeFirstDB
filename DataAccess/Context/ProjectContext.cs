using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-OTAOT39G;Database=MoviesCodeFirstDB;Trusted_Connection=True;";
        }

       public DbSet<Category> Categories { get; set; }
       
       public DbSet<Movie> Movies { get; set; }

       public DbSet<Saloon> Saloons { get; set; } 

      public DbSet<Session> Sessions { get; set; }
        
      public DbSet<Theater> Theaters { get; set; }

      public DbSet<Week> Weeks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Movies)
                .WithMany(x => x.Categories)
                .Map(map =>
                {
                    map.ToTable("MoviesCategories");
                    map.MapLeftKey("MovieID");
                    map.MapRightKey("CategoryID");
                });


            base.OnModelCreating(modelBuilder);
        }
    }
}
