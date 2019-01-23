using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface ILiving
    {
        string Breath();
        string Eat();
        string Scratch();
        string Sleep();
    }
}
