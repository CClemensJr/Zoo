using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class WarmBlooded : Animal
    {
        public virtual string Sleep()
        {
            return " sleeps for 8 hours";
        }
    }
}
