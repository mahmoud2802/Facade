using System;
using Facade.Facades;
namespace Facade
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            ComputerFacade computer = new ComputerFacade();
            computer.TurnOn();
            printInstagram();
            
        }
        static void printInstagram()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Please follow me on Instagram @mahmoud2802");
            Console.WriteLine("************************");
        }
    }
}