using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOveride.Net5._0
{
    internal class Dog : Animal
    {
        //bool property to check if dog is Happy
        public bool IsHappy { get; set; }

        //simple contructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age) 
        {
            //all dogs are happy
            IsHappy = true;
        }

        //simple override of the virtual method Eat
        public override void Eat()
        {
            //to call the eat method from our base class as we use the keyword "base"
            base.Eat();
        }

        //override of the virtual method MakeSound
        public override void MakeSound()
        {
            //since every animal will make a totally different sound
            //each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuf!.");
        }

        //override of virtual method Play
        public override void Play()
        {
            //check if the dog is happy if yes call the Play method from the base class
            if(IsHappy) 
            {
                base.Play();
            }
         
        }
    }
}
