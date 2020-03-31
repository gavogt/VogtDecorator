using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class Display
    {
        public void IngredientsMenu()
        {
            Console.WriteLine("Ingredients: ");
            Console.WriteLine("1. Cheese");
            Console.WriteLine("2. Pepperoni");
            Console.WriteLine("3. Sausage");
            Console.WriteLine("4. Onions");
            Console.WriteLine("5. Anchovies");
            Console.WriteLine("6. Mushrooms");
            Console.WriteLine("0 when done");
        }

        public void SizeOfPizzaMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Small = 1");
            Console.WriteLine("Medium = 2");
            Console.WriteLine("Large = 3");

        }

    }
}
