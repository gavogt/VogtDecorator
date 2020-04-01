using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class SmallPizza : Pizza, IAddOnDecorator
    {
        public override int GetCost()
        {
            return 10;
        }

        public override string GetDescription()
        {
            return "Small pizza";
        }
    }
}
