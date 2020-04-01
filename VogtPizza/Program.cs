using System;

namespace VogtPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = default;
            Run(new Display(), new PizzaConsoleReader(), new PizzaManager(pizza));
        }

        public static void Run(Display display, PizzaConsoleReader pizzaConsoleReader, PizzaManager pizzaManager)
        {

            var choice = 0;

            display.SizeOfPizzaMenu();
            choice = pizzaConsoleReader.GetPizzaSizeChoice();
            pizzaManager.SwitchOnChoiceForPizzaSize(choice);

            do
            {
                display.IngredientsMenu();
                choice = pizzaConsoleReader.GetIngrendientsChoice();
                pizzaManager.SwitchOnChoiceForIngredients(choice);
                pizzaManager.DisplayPizzaInfo();
            } while (choice != 0);

            Console.Clear();
            Console.WriteLine("Exiting...");

        }

    }
}
