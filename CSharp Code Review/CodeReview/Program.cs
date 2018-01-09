using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the salutation class for a walmart greeter
            Salutation oldGuy = new Salutation("Welcome to Walmart!", "Thanks for shopping at Walmart!");

            // Get the guy to talk...
            Console.WriteLine(oldGuy.Greet());
            Console.WriteLine(oldGuy.SayFarewell());
        }
    }
}
