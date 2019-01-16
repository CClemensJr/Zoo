using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        public abstract string Coloring { get; set; }
        public abstract string Hide { get; set; }
        public abstract int NumberOfLegs { get; set; }
        public abstract int NumberOfEyes { get; set; }
        public abstract bool HasClaws { get; set; }
        public abstract bool HasWings { get; set; }

        public abstract string Hunt();
        public abstract string Move();
    }
}
