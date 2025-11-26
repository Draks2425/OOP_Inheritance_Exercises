using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBase.Basics
{
    // 1. Klasa
    public class Person
    {
        // 2. Właściwości (properties)
        public string Name { get; set; }
        protected int Age { get; set; }
        private string SecretNick { get; set; }

        // 3. Metoda
        public void SayHello()
        {
            Console.WriteLine($"Yoo! I'm {Name}");
        }

        // 4. Metoda virtual
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // 5. Klasa abstrakcyjna + metoda abstrakcyjna
    public abstract class Animal
    {
        public string Type { get; set; }
        public abstract void MakeSound();
    }

    public class AccessModifiersExample
    {
        public string PublicName { get; set; } = "I'm public — visable everywhere";
        private int PrivateNumber { get; set; } = 123;
        protected string ProtectedInfo { get; set; } = "I'm protected — visable in derivatives classes";

        public void ShowValues()
        {
            Console.WriteLine(PublicName);
            Console.WriteLine(PrivateNumber);
            Console.WriteLine(ProtectedInfo);
        }
    }
}
