using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppWithMVCAndServices.Services;

namespace WebAppWithMVCAndServices.Controllers
{
    public class SampleController : Controller
    {
        private readonly IGreetingService _greetingService;
        public SampleController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        public string Index(string id)
        {
            return $"<h1>{_greetingService.Greet(id)}</h1>";
        }
    }
}