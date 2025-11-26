using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBase.Basics
{
    public class Worker : Person
    {
        public string Job { get; set; }

        // Nadpisanie metody wirtualnej (override)
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Job/Work: {Job}");
        }
    }
}
