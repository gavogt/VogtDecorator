using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    abstract class AddOnDecorator : IPizza
    {
        public abstract int GetCost();

        public abstract string GetDescription();
    }
}
