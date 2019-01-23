using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Tiger : Cat, IAttack
    {
        public override string Hide { get => Hide; set => Hide = "fur hide"; }
        public override string Coloring { get => Coloring; set => Coloring = "orange, white, and black"; }
        public override bool HasClaws { get => HasClaws; set => HasClaws = true; }
        public override bool HasWings { get => HasWings; set => HasWings = false; }
        public override int NumberOfEyes { get => NumberOfEyes; set => NumberOfEyes = 2; }
        public override int NumberOfLegs { get => NumberOfLegs; set => NumberOfLegs = 4; }

        public string Bite()
        {
            return " bites feriociously at a nearby hiker";
        }

        public override string Hunt()
        {
            return " jumps on it's prey from above";
        }

        public string Kick()
        {
            return " kicks the hiker in the kneecap";
        }

        public override string Move()
        {
            return " walks assuredly";
        }

        public string Push()
        {
            return " pushes the hiker into a tree";
        }
    }
}
