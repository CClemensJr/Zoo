using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Velociraptor : ColdBlooded
    {
        public override string Hide { get => Hide; set => Hide = "fur hide"; }
        public override string Coloring { get => Coloring; set => Coloring = "gold"; }
        public override bool HasClaws { get => HasClaws; set => HasClaws = true; }
        public override bool HasWings { get => HasWings; set => HasWings = false; }
        public override bool WalksOnAllFours { get => WalksOnAllFours; set => WalksOnAllFours = false; }
        public override int NumberOfEyes { get => NumberOfEyes; set => NumberOfEyes = 2; }
        public override int NumberOfLegs { get => NumberOfLegs; set => NumberOfLegs = 2; }

        public override string Hunt()
        {
            return " waits for it's prey to stop moving";
        }

        public override string Move()
        {
            return " hops over tables and stairs";
        }
    }
}
