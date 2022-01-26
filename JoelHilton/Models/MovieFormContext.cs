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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                //Adding my 3 movies to Database
                new MovieResponse
                {
                    ApplicationId = 1,
                    Category = "Family",
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
                    Category = "Family",
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
                       Category = "Action/Adventure",
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
