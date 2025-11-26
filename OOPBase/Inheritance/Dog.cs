using System;
using System.Collections.Generic;
using System.Text;
using OOPBase.Basics;

namespace OOPBase.Inheritance
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark bark!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Dogs name: {Name}");
        }
    }
}