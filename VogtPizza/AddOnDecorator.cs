using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    abstract class AddOnDecorator : Pizza, IPizza, IAddOnDecorator
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
