using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class MediumPizza : Pizza
    {
        public override int GetCost()
        {
            return 12;
        }

        public override string GetDescription()
        {
            return "Medium pizza";
        }
    }
}
