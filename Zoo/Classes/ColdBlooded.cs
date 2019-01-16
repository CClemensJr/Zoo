using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class ColdBlooded : Animal
    {
        public virtual bool WalksOnAllFours { get; set; } = true;

        public virtual bool ShedsSkin { get; set; } = true;
    }
}
