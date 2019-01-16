using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Cat : WarmBlooded
    {
        public virtual string Sounds()
        {
            return "Meow!";
        }
    }
}
