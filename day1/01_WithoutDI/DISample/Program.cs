using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new HelloController();
            string result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }
    }
}
