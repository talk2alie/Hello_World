using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            var greetingService = new GreetingService();
            string message = greetingService.GetGreeting();
            
            Console.WriteLine(message);
            Console.Read();
        }
    }
}
