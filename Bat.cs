using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceFirtSteps
{
     class Bat : Mammal
    {
        public Bat() : base("bat", 2, 102.5)
        {
        }
        public override void Ambulate()
        {
            Console.WriteLine("Bats fly from place to place");
        }
        public override double Sleep()
        {
            Console.WriteLine($"{creatureName} sleeps 19.9 hours");
            return 19.9;
        }
        public void Fly()
        {
            Console.WriteLine($"{creatureName} flys");
        }
        public override void See()
        {
            Console.WriteLine($"{creatureName} uses echolocation");
        }
    }

    }

