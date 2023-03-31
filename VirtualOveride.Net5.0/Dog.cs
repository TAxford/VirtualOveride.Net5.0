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
    }
}
