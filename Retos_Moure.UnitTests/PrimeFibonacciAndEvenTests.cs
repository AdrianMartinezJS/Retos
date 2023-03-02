using NUnit.Framework;
using StringAssert = NUnit.Framework.StringAssert;

namespace Retos_Moure.UnitTests
{
    [TestFixture]
    public class PrimeFibonacciAndEvenTests
    {
        /*
         * Escribe un programa que, dado un número, compruebe y muestre si es primo, fibonacci y par.
         * Ejemplos:
         * - Con el número 2, nos dirá: "2 es primo, fibonacci y es par"
         * - Con el número 7, nos dirá: "7 es primo, no es fibonacci y es impar"
         */
        private PrimeFibonacciAndEven _numberToProof;

        [SetUp]
        public void SetUp () 
        {
            _numberToProof = new PrimeFibonacciAndEven();
        }

        [Test]
        public void proof_whenCalledwithEvenNumber_returnsEvenNumber()
        {
            var result = _numberToProof.proof(4);
            StringAssert.AreEqualIgnoringCase(result, "4 is not prime, is not Fibonacci and is pair");
        }

        [Test]
        public void proof_whenCalledwithOddNumber_returnsOddNumber()
        {
            var result = _numberToProof.proof(9);
            StringAssert.AreEqualIgnoringCase(result, "9 is not prime, is not Fibonacci and is unpair");
        }

        [Test]
        public void proof_whenCalledwithPrimeAndOddNumber_returnsPrimeAndOddNumber()
        {
            var result = _numberToProof.proof(7);
            StringAssert.AreEqualIgnoringCase(result, "7 is prime, is not Fibonacci and is unpair");
        }

        [Test]
        public void proof_whenCalledwithPrimeFibonacciAndOddNumber_returnsPrimeFibonacciAndOddNumber()
        {
            var result = _numberToProof.proof(13);
            StringAssert.AreEqualIgnoringCase(result, "13 is prime, is Fibonacci and is unpair");
        }
    }
}
