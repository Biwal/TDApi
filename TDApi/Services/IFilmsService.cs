using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDApi.Models;

namespace TDApi.Services
{
    interface IFilmsService
    {
        public IEnumerable<Film> GetAllItems();
    }
}
