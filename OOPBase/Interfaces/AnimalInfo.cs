using System;
using System.Collections.Generic;
using System.Text;
using OOPBase.Inheritance;

namespace OOPBase.Interfaces
{
    // Implements IAnimalInfo and also provides a helper GetInfo(Animal)
    public class AnimalInfo : IAnimalInfo
    {
        // Implementation of interface property
        public string Description { get; private set; }

        // Parameterless ctor - you can set Description later
        public AnimalInfo() { }

        // Convenient ctor: build Description from an Animal instance
        public AnimalInfo(Animal animal)
        {
            Description = GetInfo(animal);
        }

        // Helper used previously in tests: returns the info string for a given animal
        public string GetInfo(Animal animal)
        {
            return $"Animal info: {animal.Name}";
        }

        // Implementation of interface method: prints current Description
        public void PrintDescription()
        {
            Console.WriteLine(Description);
        }

        // Optional helper: update Description from an Animal instance
        public void UpdateFrom(Animal animal)
        {
            Description = GetInfo(animal);
        }
    }
}
