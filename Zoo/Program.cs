using System;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeToTheZoo();

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        private static void WelcomeToTheZoo()
        {
            Console.WriteLine("Welcome to my zoo!");



            Console.Write("We have a Lion that:");

            Lion lion = new Lion();

            Console.WriteLine(lion.Scratch());


            Console.Write("We have a Tiger that:");

            Tiger tiger = new Tiger();

            Console.WriteLine(tiger.Hunt());


            Console.Write("We have a Bear that:");

            Bear bear = new Bear();

            Console.WriteLine(bear.Sleep());


            Console.Write("We have a Crocodile that:");

            Crocodile crocodile = new Crocodile();

            Console.WriteLine(crocodile.Move());


            Console.Write("And a Velociraptor that:");

            Velociraptor velociraptor = new Velociraptor();

            Console.WriteLine(velociraptor.Move());

            Console.WriteLine("This is probably the best zoo ever");


        }
    }
}
