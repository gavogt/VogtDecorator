using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    abstract class AddOnDecorator : Pizza
    {
        public override int GetCost()
        {
            return 0;
        }

        public override string GetDescription()
        {
            return "";
        }
    }
}
