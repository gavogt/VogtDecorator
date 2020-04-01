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

        public Pizza SwitchOnChoiceForIngredients(int choice, Pizza tempDecorator)
        {
            
            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    tempDecorator = new Cheese(tempDecorator);
                    break;
                case 2:
                    tempDecorator = new Pepperoni(tempDecorator);
                    break;
                case 3:
                    tempDecorator = new Sausage(tempDecorator);
                    break;
                case 4:
                    tempDecorator = new Onions(tempDecorator);
                    break;
                case 5:
                    tempDecorator = new Anchovies(tempDecorator);
                    break;
                case 6:
                    tempDecorator = new Mushrooms(tempDecorator);
                    break;
                default:
                    Console.WriteLine("Please press 0 - 6!");
                    break;
            }

            return tempDecorator;
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
    }
}
