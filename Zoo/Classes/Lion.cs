using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Lion : Cat, ILiving, IAttack
    {
        public override string Hide { get => Hide; set => Hide = "fur hide"; }
        public override string Coloring { get => Coloring; set => Coloring = "gold"; }
        public override bool HasClaws { get => HasClaws; set => HasClaws = true; }
        public override bool HasWings { get => HasWings; set => HasWings = false; }
        public override int NumberOfEyes { get => NumberOfEyes; set => NumberOfEyes = 2; }
        public override int NumberOfLegs { get => NumberOfLegs; set => NumberOfLegs = 4; }

        public string Bite()
        {
            return " bites at the flesh of it's prey";
        }

        public string Breath()
        {
            return " is breathing heavily";
        }

        public string Eat()
        {
            return " gnaws hungrily at a carcass.";
        }

        public override string Hunt()
        {
            return " stalks it's prey";
        }

        public string Kick()
        {
            return " kicked out windly with it's hind legs";
        }

        public override string Move()
        {
            return " runs through the tall grass";
        }

        public string Push()
        {
            return " knocked the rat aside";
        }

        public string Scratch()
        {
            return " raked it's claws through the metal doors.";
        }

        public override string Sounds()
        {
            return "ROOAAAARRRR";
        }
    }
}
