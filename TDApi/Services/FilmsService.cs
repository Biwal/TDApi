using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDApi.Models;

namespace TDApi.Services
{
    public class FilmsService:IFilmsService
    {
        private readonly FilmsContext _context;

        public FilmsService(FilmsContext context)
        {
            _context = context;
        }

        IEnumerable<Film> IFilmsService.GetAllItems()
        {
            throw new NotImplementedException();
        }
    }
}
