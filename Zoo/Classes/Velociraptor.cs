using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Velociraptor : ColdBlooded
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
            return " stalks it's prey";
        }

        public override string Move()
        {
            return " runs through the tall grass";
        }
    }
}
