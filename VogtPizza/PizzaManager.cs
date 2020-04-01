using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class PizzaManager
    {
        private Pizza _pizza;
        public PizzaManager(Pizza pizza)
        {
            _pizza = pizza;
        }

        public Pizza SwitchOnChoiceForIngredients(int choice)
        {
            
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    _pizza = new Cheese(_pizza);
                    break;
                case 2:
                    _pizza = new Pepperoni(_pizza);
                    break;
                case 3:
                    _pizza = new Sausage(_pizza);
                    break;
                case 4:
                    _pizza = new Onions(_pizza);
                    break;
                case 5:
                    _pizza = new Anchovies(_pizza);
                    break;
                case 6:
                    _pizza = new Mushrooms(_pizza);
                    break;
                default:
                    Console.WriteLine("Please press 0 - 6!");
                    break;
            }

            return _pizza;
        }

        public Pizza SwitchOnChoiceForPizzaSize(int choice)
        {

            switch (choice)
            {
                // Small pizza
                case 1:
                    _pizza = new SmallPizza();
                    break;
                // Medium pizza
                case 2:
                    _pizza = new MediumPizza();
                    break;
                // Large pizza
                case 3:
                    _pizza = new LargePizza();
                    break;
                default:
                    Console.WriteLine("Please enter 1, 2 or 3");
                    break;
            }

            return _pizza;
        }

        public void DisplayPizzaInfo()
        {
            Console.Write($"{_pizza.GetDescription()} costs {_pizza.GetCost():C2}");

        }
    }
}
