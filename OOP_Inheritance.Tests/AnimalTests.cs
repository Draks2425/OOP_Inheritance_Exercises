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
            // Arrange
            var dog = new Dog();
            dog.Name = "Reksio";

            using var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            dog.MakeSound();
            dog.ShowInfo();

            var output = writer.ToString();

            // Assert
            Assert.Contains("Bark bark!", output);
            Assert.Contains("Dogs name: Reksio", output);
        }
    }
}
