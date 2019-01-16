﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Tiger : Cat
    {
        public override string Hide { get => Hide; set => Hide = "fur hide"; }
        public override string Coloring { get => Coloring; set => Coloring = "orange, white, and black"; }
        public override bool HasClaws { get => HasClaws; set => HasClaws = true; }
        public override bool HasWings { get => HasWings; set => HasWings = false; }
        public override int NumberOfEyes { get => NumberOfEyes; set => NumberOfEyes = 2; }
        public override int NumberOfLegs { get => NumberOfLegs; set => NumberOfLegs = 4; }

        public override void Hunt()
        {
            Console.WriteLine(" jumps on it's prey from above");
        }

        public override void Move()
        {
            Console.WriteLine(" walks assuredly");
        }
    }
}