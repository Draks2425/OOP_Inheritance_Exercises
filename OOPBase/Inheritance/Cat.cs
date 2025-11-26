using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBase.Inheritance
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Cat name: {Name}");
        }
    }
}
