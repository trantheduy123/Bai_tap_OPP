using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_interface
{
    internal class Program

    {
        internal interface Ipet
        {
            void feed();
            void sound();
        }

        internal interface Ibird
        {
            void fly();
            void sound();
            void feed();
        }

        internal class cat : Ipet
        {
            public cat() => Console.WriteLine("toi la meo");
            public void feed() => Console.WriteLine("meo an ca");
            public void sound() => Console.WriteLine("meo meo");
        }

        internal class parrot : Ibird, Ipet
        {
            public parrot() => Console.WriteLine("toi la vet");
            public void fly() => Console.WriteLine("toi co the bay");
            public void sound() => Console.WriteLine("chip chip");
            public void feed() => Console.WriteLine("vet an lua");

            void Ipet.sound() => Console.WriteLine("toi co the hat");
            void Ibird.sound() => Console.WriteLine("toi co the noi chuyen");
        }


        internal class petlover
        {
            private Ipet _pet;
            public petlover(Ipet pet) => _pet = pet;

            public void play()
            {
                Console.WriteLine("muon an cai gi");
                _pet.feed();
                Console.WriteLine("muon noi cai gi");
                _pet.sound();

            }
        }


        internal class birdlover
        {
            private Ibird _bird;
            public birdlover(Ibird bird) => _bird = bird;
            public void play()
            {
                Console.WriteLine("muon an cai gi");
                _bird.feed();
                Console.WriteLine("muon noi cai gi");
                _bird.sound();
            }
        }


        static void Main(string[] args)
        {
            

            Ibird bird = new parrot();
            birdlover birdlover = new birdlover(bird);
            birdlover.play();

            Ipet pet = new parrot();
            petlover petlover = new petlover(pet);
            petlover.play();

            

            Console.ReadKey();
        }
    }
}
