using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class Cheese : AddOnDecorator
    {
        private Pizza _pizza;

        public Cheese(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 2;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Cheese";
        }

    }
}
