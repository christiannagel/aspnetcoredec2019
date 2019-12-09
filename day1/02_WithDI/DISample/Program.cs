using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new HelloController(new GreetingService());
            string result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }
    }
}
