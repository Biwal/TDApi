using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDApi.Controllers;
using TDApi.Models;
using Xunit;

namespace TDApiTesting
{
    public class FilmsControllerTest
    {


        [Fact]
        public async  Task Get_WhenCalled_ReturnsOkResultAsync()
        {
            var dbContext = DbContextMocker.GetWideWorldImportersDbContext(nameof(Get_WhenCalled_ReturnsOkResultAsync));
            var controller = new FilmsController( dbContext);
            
            // Act
            var response = await controller.GetFilms() as ObjectResult;
            var value = response.Value as IPagedResponse<Film>;
           
            dbContext.Dispose();

            // Assert
            Assert.False(value.DidError);
        }
    }
}
