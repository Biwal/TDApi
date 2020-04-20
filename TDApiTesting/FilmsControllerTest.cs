using System;
using System.Collections.Generic;
using System.Text;
using TDApi.Controllers;

namespace TDApiTesting
{
    class FilmsControllerTest
    {
        FilmsController _controller;

        public FilmsControllerTest()
        {
            _controller = new FilmsController(null);
        }
    }
}
