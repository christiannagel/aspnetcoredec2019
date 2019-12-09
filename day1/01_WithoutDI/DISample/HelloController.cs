using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class HelloController
    {
        public string Index(string name)
        {
            var service = new GreetingService();
            string result = service.Greet(name);
            return result.ToUpper();
        }
    }
}
