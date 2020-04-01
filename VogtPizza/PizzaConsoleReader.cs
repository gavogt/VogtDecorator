using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    
    class PizzaConsoleReader
    {
        public int GetIngrendientsChoice()
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

        public int GetPizzaSizeChoice()
        {
            var choice = 0;

            do
            {
                Console.Write("What type of pizza: ");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice < 1 || choice > 3);

            Console.WriteLine($"Picked - {choice}");

            return choice;
        }

    }
    
}
