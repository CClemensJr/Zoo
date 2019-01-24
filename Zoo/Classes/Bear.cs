using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Bear : WarmBlooded, ILiving
    {
        public override string Hide { get => Hide; set => Hide = "fur hide"; }
        public override string Coloring { get => Coloring; set => Coloring = "brown"; }
        public override bool HasClaws { get => HasClaws; set => HasClaws = true; }
        public override bool HasWings { get => HasWings; set => HasWings = false; }
        public override int NumberOfEyes { get => NumberOfEyes; set => NumberOfEyes = 2; }
        public override int NumberOfLegs { get =>  NumberOfLegs; set => NumberOfLegs = 4; }

        public string Breath()
        {
            return " is breathing deeply";
        }

        public string Eat()
        {
            return " is eating the fish";
        }

        public override string Hunt()
        {
            return " goes fishing";
        }

        public override string Move()
        {
            return " lumbers thorugh the forest";
        }

        public string Scratch()
        {
            return " is scratching his buttocks.";
        }

        public override string Sleep()
        {
            return " sleeps for months on end.";
        }
    }
}
