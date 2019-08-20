using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceFirtSteps
{
      abstract class Mammal
    {
       protected readonly int legs = 4; // protecgt can only be viewed in base and derived class
       protected readonly string creatureName; // only can read it.
       protected readonly double internalTemperature; // can only be used twice

        protected Mammal(string creatureName, double internalTemperature) // Mammal is the constructor
        {
            this.creatureName = creatureName;   
            this.internalTemperature = internalTemperature;

        }
        protected Mammal(string creatureName, int legs, double internalTemperature)// set as class scope this.
        {
            this.creatureName = creatureName;
            this.legs = legs;
            this.internalTemperature = internalTemperature;

        }
        public virtual void See()
        {
            Console.WriteLine($"{creatureName} sees");
        }
        public virtual void Eat()                                   // designed to be overridden by derived class
        {
            Console.WriteLine($"{creatureName} eat");
        }
      public virtual void Gestate()
        {
            Console.WriteLine($"{creatureName} gestate");
        }
      public  virtual void Lactate()
        {
            Console.WriteLine($"{creatureName} lactact");
        }
      public virtual void Ambulate()
        {
            Console.WriteLine($"{creatureName} Ambulating on {legs} legs");
        }
        public abstract double Sleep(); // abstract means i have amethod with no good implentation have to be overridden
     
    }

    }

