using System;

namespace VogtPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = default;
            Run(new PizzaMenu(), new PizzaConsoleReader(), new PizzaBuilder(pizza));
        }

        public static void Run(PizzaMenu display, PizzaConsoleReader pizzaConsoleReader, PizzaBuilder pizzaManager)
        {

            var choice = 0;

            display.SizeOfPizzaMenu();
            choice = pizzaConsoleReader.GetPizzaSizeChoice();
            pizzaManager.SwitchOnChoiceForPizzaSize(choice);

            do
            {
                display.IngredientsMenu();
                choice = pizzaConsoleReader.GetIngrendientsChoice();
                pizzaManager.AddIngredients(choice);
                pizzaManager.DisplayPizzaInfo();
            } while (choice != 0);

            Console.Clear();
            Console.WriteLine("Exiting...");

        }

    }
}
