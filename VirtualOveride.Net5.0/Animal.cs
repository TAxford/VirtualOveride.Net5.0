using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOveride.Net5._0
{
    internal class Animal
    {
        //name properties        
        public string Name { get; set; }
        //age property
        public int Age { get; set; }
        //is hungry boolean to check wether the animal is hungry
        public bool IsHungry { get; set; }

        //simple constructor
        public Animal(string name, int age)
        {
            Name = name; 
            Age = age;
            //in our case all our animals are hungry by default
            IsHungry= true;
        }

        //an empty virtual method MakeSound for other classes to Override
        public virtual void MakeSound()
        {

        }
    }
}
