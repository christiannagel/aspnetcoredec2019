using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingSample
{
    public class MyService
    {
        private readonly ILogger _logger;
        public MyService(ILogger<MyService> logger)
        {
            _logger = logger;
        }

        public void Foo()
        {
            _logger.LogError("Foo called");
        }
    }
}
