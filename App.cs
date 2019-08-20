using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceFirtSteps
{
 
        class App
        {
            public void Run()
            {
                var bat = new Bat();  // will be able to refer to mammal
                var human = new Human();
                var cow = new Cow();

                var mammals = new List<Mammal>() { human, bat, cow }; // or pass them into a list of mammals

                foreach (var mammal in mammals) // var is taking from mammal list
                {
                    DoMammalStuff(mammal);
                }

                //DoMammalStuff(bat);
                //DoMammalStuff(human);
                //DoMammalStuff(cow);
            }
            private void DoMammalStuff(Mammal mammal) // taking in mammal and do something special
            {
                Bat asBat = mammal as Bat;  // 
                mammal.Eat();
                mammal.See();
                //if (asBat != null) // specifily changes ambualte to stampede for only the cow
                //{
                //    asBat.Fly();
                //}
                //else
                //{
                //    mammal.See();
                //}

                if (mammal is Bat cow)
                {
                    cow.Ambulate();
                }
                else
                {
                    mammal.Ambulate();
                }

                var totalSleep = mammal.Sleep();

                
                mammal.Lactate();

                totalSleep += mammal.Sleep();
                Console.WriteLine($"total hours of sleep: {totalSleep}" + "\n");
            }

        }

    }
   
