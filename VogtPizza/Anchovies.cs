using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class Anchovies: AddOnDecorator
    {
        private Pizza _pizza;
        public Anchovies(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Anchovies";
        }

    }
}
