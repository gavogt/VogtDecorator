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
            this._pizza = pizza;
        }

        public override int GetCost()
        {
            return this._pizza.GetCost()+2;
        }

        public override string GetDescription()
        {
            return this._pizza.GetDescription()+"Cheese ";
        }

    }
}
