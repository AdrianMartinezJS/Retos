using NUnit.Framework;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text.RegularExpressions;
using Assert = NUnit.Framework.Assert;
using StringAssert = NUnit.Framework.StringAssert;

namespace Retos_Moure.UnitTests
{
    [TestFixture]
    public class PasswordGeneratorTests
    {
        /*
         * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
         * Podrás configurar generar contraseñas con los siguientes parámetros:
         * - Longitud: Entre 8 y 16.
         * - Con o sin letras mayúsculas.
         * - Con o sin números.
         * - Con o sin símbolos.
         * (Pudiendo combinar todos estos parámetros entre ellos)
         */

        [Test]
        public void GeneratePassword_whenCalled_GeneratesRandomPasswordWithProperLength() 
        {
            var passwordGenerator = new PasswordGenerator();
            
            var result = passwordGenerator.generatePassword();
            
            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
        }

        [Test]
        public void GeneratePassword_whenCalledWithCapitalLetters_GeneratesRandomPasswordWithCAPS()
        {
            var passwordGenerator = new PasswordGenerator("yes");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.IsMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.DoesNotMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithNoCapitalLetters_GeneratesRandomPasswordNoCAPS()
        {
            var passwordGenerator = new PasswordGenerator("no");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.DoesNotMatch(@"[A-Z]", result);
            StringAssert.IsMatch(@"[a-z]", result);
            StringAssert.DoesNotMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithCapitalLettersAndNumbers_GeneratesRandomPasswordWithCAPSAndNumbers()
        {
            var passwordGenerator = new PasswordGenerator("yes", "Yes");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.IsMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.IsMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithCapitalLettersNoNumbers_GeneratesRandomPasswordWithCAPSNoNumbers()
        {
            var passwordGenerator = new PasswordGenerator("yes", "no");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.IsMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.DoesNotMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledNoCAPSButNumbers_GeneratesRandomPasswordWithNumbers()
        {
            var passwordGenerator = new PasswordGenerator("no", "yes");
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.DoesNotMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.IsMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledNoCAPSNoNumbers_GeneratesRandomPasswordNoCAPSNoNumbers()
        {
            var passwordGenerator = new PasswordGenerator("no", "no");
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.DoesNotMatch(@"[A-Z]", result);
            StringAssert.IsMatch(@"[a-z]", result);
            StringAssert.DoesNotMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithCapitalLettersNumbersAndSymbols_GeneratesRandomCapitalizedPasswordWithLettersNumbersAndSymbols()
        {
            var passwordGenerator = new PasswordGenerator("yes", "Yes", "Yes");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.IsMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.IsMatch(@"\d", result);
            StringAssert.IsMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithSymbols_GeneratesRandomPasswordWithLowercaseLettersAndSymbols()
        {
            var passwordGenerator = new PasswordGenerator("no", "no", "yes");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.DoesNotMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.DoesNotMatch(@"\d", result);
            StringAssert.IsMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithNumbersAndSymbols_GeneratesRandomPasswordWithLowercaseLettersNumbersAndSymbols()
        {
            var passwordGenerator = new PasswordGenerator("no", "yes", "yes");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.DoesNotMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.IsMatch(@"\d", result);
            StringAssert.IsMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithCAPSNumbersAndSymbols_GeneratesRandomPasswordWithCAPSNumbersAndSymbols()
        {
            var passwordGenerator = new PasswordGenerator("yes", "no", "no");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.IsMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.DoesNotMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledWithCAPSNumbersNoSymbols_GeneratesRandomPasswordWithCAPSNumbersButNoSymbols()
        {
            var passwordGenerator = new PasswordGenerator("yes", "yes", "no");
            
            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.IsMatch(@"[A-Z]", result);
            StringAssert.DoesNotMatch(@"[a-z]", result);
            StringAssert.IsMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

        [Test]
        public void GeneratePassword_whenCalledNoCAPSNoNumbersNoSymbols_GeneratesRandomPasswordNoCAPSNoNumbersNoSymbols()
        {
            var passwordGenerator = new PasswordGenerator("no", "no", "no");

            var result = passwordGenerator.generatePassword();

            Assert.IsTrue(result.Length <= 16 && result.Length >= 8);
            StringAssert.DoesNotMatch(@"[A-Z]", result);
            StringAssert.IsMatch(@"[a-z]", result);
            StringAssert.DoesNotMatch(@"\d", result);
            StringAssert.DoesNotMatch(@"\W", result);
        }

    }
}
