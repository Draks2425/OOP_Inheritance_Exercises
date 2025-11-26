using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBase.Inheritance
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void MakeSound();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Animal: {Name}");
        }
    }
}


