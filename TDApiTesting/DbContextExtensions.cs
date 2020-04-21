using System;
using System.Collections.Generic;
using System.Text;
using TDApi.Models;

namespace TDApiTesting
{
    public static class DbContextExtensions
    {
        public static void Seed(this FilmsContext dbContext)
        {
            // Add entities for DbContext instance

            dbContext.Genres.AddRange(
                                new Genre { Libelle = "Action" },
                                new Genre { Libelle = "Crime" },
                                new Genre { Libelle = "Comédie" },
                                new Genre { Libelle = "Horreur" },
                                new Genre { Libelle = "Drame" },
                                new Genre { Libelle = "Animation" },
                                new Genre { Libelle = "Musical" },
                                new Genre { Libelle = "Biographie" },
                                new Genre { Libelle = "Aventure" },
                                new Genre { Libelle = "Science-fiction" });

            dbContext.SaveChanges();

            dbContext.Films.AddRange(
                    new Film
                    {
                        Titre = "300",
                        DateSortie = DateTime.Parse("2016-01-01"),
                        GenreId = 1,
                        Note = 4
                    },
                    new Film
                    {
                        Titre = "Psycho",
                        DateSortie = DateTime.Parse("2019-01-01"),
                        GenreId = 2,
                        Note = 4
                    },
                    new Film
                    {
                        Titre = "How High",
                        DateSortie = DateTime.Parse("2016-01-01"),
                        GenreId = 3,
                        Note = 4
                    });



            dbContext.SaveChanges();
        }
    }
}
