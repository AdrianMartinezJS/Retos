using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Retos_Moure.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        /*
        * Escribe un programa que muestre por consola(con un print) los
        * números de 1 a 100 (ambos incluidos y con un salto de línea entre
        * cada impresión), sustituyendo los siguientes:
        * - Múltiplos de 3 por la palabra "fizz".
        * - Múltiplos de 5 por la palabra "buzz".
        * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
        */

        private FizzBuzz? _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void checkForDivider_DivisibleByThree_ReturnFizz()
        {
            // Arrange
            // done in Setup

            // Act
            var result = _fizzBuzz.checkForDivider(3);

            // Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void checkForDivider_DivisibleByFive_ReturnBuzz()
        {
            // Act
            var result = _fizzBuzz.checkForDivider(5);

            // Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void checkForDivider_DivisibleByThreeAndFive_ReturnFizzBuzz(int number)
        {
            // Act
            var result = _fizzBuzz.checkForDivider(number);

            // Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void checkForDivider_NotDivisibleByThreeOrFive_ReturnTheNumber()
        {
            // Act
            var result = _fizzBuzz.checkForDivider(4);

            // Assert
            Assert.That(result, Is.EqualTo("4"));
        }
    }
}
