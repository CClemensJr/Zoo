using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Crocodile : ColdBlooded
    {
        public override string Hide { get => Hide; set => Hide = "scaly hide"; }
        public override string Coloring { get => Coloring; set => Coloring = "green"; }
        public override bool HasClaws { get => HasClaws; set => HasClaws = true; }
        public override bool HasWings { get => HasWings; set => HasWings = false; }
        public override bool ShedsSkin { get => ShedsSkin; set => ShedsSkin = false; }
        public override int NumberOfEyes { get => NumberOfEyes; set => NumberOfEyes = 2; }
        public override int NumberOfLegs { get => NumberOfLegs; set => NumberOfLegs = 4; }

        public override void Hunt()
        {
            Console.WriteLine(" waits patiently for an unsuspecting victim in the water");
        }

        public override void Move()
        {
            Console.WriteLine(" swims quietly through the water");
        }


    }
}
