using Xunit;
using System;
using System.IO;
using OOPBase.Inheritance;
using OOPBase.Interfaces;

namespace OOP_Inheritance.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Dog_Should_MakeSound_AndShowInfo()
        {
            var dog = new Dog { Name = "Reksio" };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                dog.MakeSound();
                dog.ShowInfo();
                var output = sw.ToString();
                Assert.Contains("Bark bark!", output);
                Assert.Contains("Dogs name: Reksio", output);
            }
        }

        [Fact]
        public void Cat_Should_Implement_IAnimalInfo_And_PrintDescription()
        {
            var cat = new Cat { Name = "Gacek" };

            // Check that cat implements the interface (compile-time check)
            Assert.IsAssignableFrom<IAnimalInfo>(cat);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                // call interface method
                cat.PrintDescription();
                var output = sw.ToString();
                Assert.Contains("Gacek is a cat that says Meow", output);
            }
        }
        //[Fact]
        //public void Call_method_interface()
        //{
        //    IAnimalInfo animalInfo =  new Cat { Name = "Reksio" };
        //    animalInfo.Description.Should().Be("Reksio is a cat that says Meow");
        //}
    }
}
