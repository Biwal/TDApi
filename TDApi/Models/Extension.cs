using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDApi.Models
{
    public static class WideWorldImportersDbContextExtensions
    {
        public static IQueryable<Film> GetStockItems(this FilmsContext dbContext, int pageSize = 10, int pageNumber = 1, int? lastEditedBy = null, int? colorID = null, int? outerPackageID = null, int? supplierID = null, int? unitPackageID = null)
        {
            // Get query from DbSet
            var query = dbContext.Films.AsQueryable();
/*
            // Filter by: 'UnitPackageID'
            if (unitPackageID.HasValue)
                query = query.Where(item => item.UnitPackageID == unitPackageID);*/

            return query;
        }

        public static async Task<Film> GetStockItemsAsync(this FilmsContext dbContext, Film entity)
            => await dbContext.Films.FirstOrDefaultAsync(item => item.Titre == entity.Titre);

      
    }

    public static class IQueryableExtensions
    {
        public static IQueryable<TModel> Paging<TModel>(this IQueryable<TModel> query, int pageSize = 0, int pageNumber = 0) where TModel : class
            => pageSize > 0 && pageNumber > 0 ? query.Skip((pageNumber - 1) * pageSize).Take(pageSize) : query;
    }
}
