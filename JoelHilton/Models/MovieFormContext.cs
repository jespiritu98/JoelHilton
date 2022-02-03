using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHilton.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            //Leaving blank for now
        }
        public DbSet<MovieResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seed data

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 6, CategoryName = "Television" },
                new Category { CategoryId = 7, CategoryName = "VHS" }
                );
            
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    ApplicationId = 1,
                    CategoryId = 4,
                    Title = "Forever Strong",
                    Year = "2008",
                    Director = "Ryan Little",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo ="",
                    Notes = ""
                },
                new MovieResponse
                {
                    ApplicationId = 2,
                    CategoryId = 4,
                    Title = "Encanto",
                    Year = "2021",
                    Director = "Jared Bush",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                },
                   new MovieResponse
                   {
                       ApplicationId = 3,
                       CategoryId = 1,
                       Title = "Spiderman: No Way Home",
                       Year = "2021",
                       Director = "Jon Watts",
                       Rating = "PG-13",
                       Edited = false,
                       LentTo = "",
                       Notes = ""

                   }
                );
        }
    }
}
