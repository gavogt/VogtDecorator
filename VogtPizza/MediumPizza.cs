using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class MediumPizza : Pizza, IAddOnDecorator
    {
        public override int GetCost()
        {
            return 12;
        }
    }
}
