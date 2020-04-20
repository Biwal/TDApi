using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TDApi.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Libelle { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
