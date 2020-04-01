using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    abstract class Pizza : IPizza
    {
        public virtual string GetDescription()
        {
            return "Plain Pizza";
        }

        public abstract int GetCost();

    }
}
