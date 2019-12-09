using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class HelloController
    {
        private readonly IGreetingService _greetingService;

        public HelloController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public string Index(string name)
        {
            string result = _greetingService.Greet(name);
            return result.ToUpper();
        }
    }
}
