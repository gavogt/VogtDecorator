using System;

namespace VogtPizza
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Run(new Display(), new PizzaConsoleReader() );
        }

        public static void Run(Display display, PizzaConsoleReader pizzaConsoleReader)
        {
            Pizza pizza = default;
            PizzaManager pizzaManager = new PizzaManager(pizza);

            var choice = 0; 

            display.SizeOfPizzaMenu();

            display.IngredientsMenu();

            //choice = pizzaConsoleReader.GetPizzaSizeChoice();


            // if choice 1 and choice 5 do small cheese pizza
            // new SmallPizza(new CheesePizza)
        }
    }
}
