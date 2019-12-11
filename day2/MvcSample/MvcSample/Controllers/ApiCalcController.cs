using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSample.Controllers
{
    [Route("MyCalc")]
    public class ApiCalcController
    {
        [HttpGet]
        public int Add(int x, int y) => x + y;
    }
}
