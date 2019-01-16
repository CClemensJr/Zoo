using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class WarmBlooded : Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("Sleeps for 8 hours");
        }
    }
}
