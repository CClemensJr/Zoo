using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animal
    {
        public abstract string Coloring { get; set; }
        public abstract string Hide { get; set; }

        public abstract void Hunt();
        public abstract void Move();
    }
}
