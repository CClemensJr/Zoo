using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Cat : WarmBlooded
    {
        public virtual string Sounds()
        {
            return "Meow!";
        }
    }
}
