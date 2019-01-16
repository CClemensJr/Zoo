using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class ColdBlooded : Animal
    {
        public virtual void WalksOnAllFours()
        {
            Console.WriteLine(" walks on all fours");
        }
    }
}
