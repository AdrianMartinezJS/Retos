using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Retos_Moure.UnitTests
{
    /*
     * Escribe un programa que reciba un texto y transforme lenguaje natural a
     * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
     *  se caracteriza por sustituir caracteres alfanuméricos.
     * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
     *   con el alfabeto y los números en "leet".
     *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
     */

    [TestFixture]
    public class HackerLanguageTests
    {
        private HackerLanguage? _hackerLanguage;
        [SetUp] 
        public void SetUp() 
        {
            _hackerLanguage = new HackerLanguage();
        }

        [Test]
        public void transformStringToLeet_emptyString_returnEmptyText()
        {
            var result = _hackerLanguage.transformStringToLeet("");
            
            Assert.That(result,Is.EqualTo("Provide a normal Text!"));
        }

        [Test]
        public void transformStringToLeet_oneWord_returnWordAsLeet()
        {
            var result = _hackerLanguage.transformStringToLeet("hola");

            Assert.That(result, Is.EqualTo("#014"));
        }

        [Test]
        public void transformStringToLeet_moreThanOneWordAndNumbersWithWhiteSpaces_returnAllWordsAsLeet()
        {
            var result = _hackerLanguage.transformStringToLeet("Esto es 1 test");

            Assert.That(result, Is.EqualTo("3570 35 L 7357"));
        }
    }
}
