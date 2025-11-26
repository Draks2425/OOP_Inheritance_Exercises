using System;
using System.Collections.Generic;
using System.Text;
using OOPBase.Interfaces; // <-- add this

namespace OOPBase.Inheritance
{
    public class Cat : Animal, IAnimalInfo
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Cat name: {Name}");
        }

        // IAnimalInfo implementation
        public string Description => $"{Name} is a cat that says Meow.";

        public void PrintDescription()
        {
            Console.WriteLine(Description);
        }
    }
}
