using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDApi.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FilmsContext())
            {
                if (context.Films.Any())
                {
                    return;   // DB has been seeded !
                }

                context.Genres.AddRange(
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

                context.SaveChanges();

                context.Films.AddRange(
                        new Film
                        {
                            Titre = "100 mètres",
                            DateSortie = DateTime.Parse("2016-01-01"),
                            GenreId = 5,
                            Note = 4
                        },
                        new Film
                        {
                            Titre = "I Am Mother",
                            DateSortie = DateTime.Parse("2019-01-01"),
                            GenreId = 10,
                            Note = 4
                        },
                        new Film
                        {
                            Titre = "Catfight",
                            DateSortie = DateTime.Parse("2016-01-01"),
                            GenreId = 3,
                            Note = 4
                        });

                context.SaveChanges();
            }

        }
    }
}
