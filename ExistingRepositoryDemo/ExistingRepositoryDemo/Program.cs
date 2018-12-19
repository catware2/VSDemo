using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingRepositoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintClass.PrintMessage();

            Console.WriteLine("Are we Finished?");
            
            Console.WriteLine("Possibly...");
            
            PrintClass2.PrintMessage();

            Console.WriteLine("Now in Master branch");

            Console.WriteLine("Finished");

            Console.ReadLine();
        }
    }
}
