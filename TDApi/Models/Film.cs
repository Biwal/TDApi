using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TDApi.Models
{
    public class Film
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9&\-'!\s]*$")]
        [StringLength(80, ErrorMessage = "Le titre ne peut être plus de 80 caractères.")]
        [Required(ErrorMessage = "Le titre est obligatoire")]
        public string Titre { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }

        [Range(0, 5, ErrorMessage = "La note doit être contenue entre 0 et 5.")]
        public double Note { get; set; }

        [Required(ErrorMessage = "Le genre est obligatoire")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
