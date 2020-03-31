using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class PizzaConsoleReader
    {
        public int GetChoice()
        {
            var choice = 0;

            do
            {
                Console.WriteLine("Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice <= 0 || choice > 6);

            Console.WriteLine($"Picked - {choice}");

            return choice;
        }
    }
}
