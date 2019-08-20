using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceFirtSteps
{
  
      class Human : Mammal // base is calling both the protected classes
    {
        //public Human() 
        //    : base( "Human", 2, 98.6) // call base construct for mammal, is required to set readonly values
        
         public Human()  //human is constructor
            :this (98.6)
         { }
        
        protected Human(double bodyTemp) //protected only allows derived and base class to modify program
            :base("Human" , 2, bodyTemp)
        { }
       
        public override double Sleep()
        {
            Console.WriteLine("Human sleeps 8 hours");
            return 8.0;
        }
    }

    class Ginger : Human
    {
        public Ginger() : base(92.0)
        { }
    }


}
