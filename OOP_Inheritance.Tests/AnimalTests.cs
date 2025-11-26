using OOPBase.Inheritance;
using Xunit;
using System;

namespace OOP_Inheritance.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Dog_Should_MakeSound_AndShowInfo()
        {
            var dog = new Dog();
            dog.Name = "Reksio";

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
        public void Cat_Should_MakeSound_AndShowInfo()
        {
            var cat = new Cat();
            cat.Name = "Mruczek";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                cat.MakeSound();
                cat.ShowInfo();

                var output = sw.ToString();

                Assert.Contains("Meow!", output);
                Assert.Contains("Cat name: Mruczek", output);
            }
        }
    }
}
