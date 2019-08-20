using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceFirtSteps
{
      class Cow : Mammal
    {
        public Cow() : base( "Cow", 101.5) // 2 argument constuctor is called, sets legs to 4 
            {       
            }

        public new void Lactate()
        {
            Console.WriteLine($"{creatureName} creates delicious creamy milk by the 2 gallons");
        }
        public override void Eat()
        {
            base.Eat(); //calls base class Eats (mammals) 
            Console.WriteLine($"{creatureName} digests woth 8 \"stomachs\"");
        }

        public override double Sleep()
        {
            Console.WriteLine($"{creatureName} sleeps 4 hours");
            return 4.0;
        }
        public void Stampede()
        {

            Console.WriteLine(" i will stampede your face!");
        }

    }

    }

