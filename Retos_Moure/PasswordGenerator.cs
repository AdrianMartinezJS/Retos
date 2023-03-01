using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retos_Moure
{
    public class PasswordGenerator
    {
        private string _password = "";
        private int _length;
        private string _letters = "abcdefghijklmnopqrstuvwxyz";
        private string _numbers = "0123456789";
        private string _symbols = "!_%&$/.-<>";
        private string _allSelectedTogether = "";
        private Random _randomNumber = new Random();

        public PasswordGenerator() 
        {
            _allSelectedTogether = _letters;
        }
        public PasswordGenerator(string capitals)
        {
            if (capitals == "yes")
            {
                _allSelectedTogether += _letters.ToUpper();
                _password += getRandomCharFromString(_letters.ToUpper());
            }
            if (capitals != "yes")
                _allSelectedTogether += _letters;
        }
        public PasswordGenerator(string capitals, string numbers)
        {
            if (capitals.ToLower() == "yes")
            {
                _allSelectedTogether += _letters.ToUpper();
                _password += getRandomCharFromString(_letters.ToUpper());
            }
            if (numbers.ToLower() == "yes")
            {
                _allSelectedTogether += _numbers;
                _password += getRandomCharFromString(_numbers);
            }
            if (capitals.ToLower() != "yes" && numbers.ToLower() != "yes")
                _allSelectedTogether += _letters;
        }
        public PasswordGenerator(string capitals, string numbers, string symbols)
        {
            if (capitals.ToLower() == "yes")
            {
                _allSelectedTogether += _letters.ToUpper();
                _password += getRandomCharFromString(_letters.ToUpper());
            }
            if (numbers.ToLower() == "yes")
            {
                _allSelectedTogether += _numbers;
                _password += getRandomCharFromString(_numbers);
            }
            if (symbols.ToLower() == "yes")
            {
                _allSelectedTogether += _symbols;
                _password += getRandomCharFromString(_symbols);
            }
            if (capitals.ToLower() != "yes" && numbers.ToLower() != "yes" && symbols.ToLower() != "yes")
                _allSelectedTogether += _letters;
        }

        private char getRandomCharFromString(string input)
        {
            int index = _randomNumber.Next(input.Length);
            return input[index];
        }

        public string generatePassword()
        {
            Console.WriteLine("_password.Length = " + _password.Length);
            Console.WriteLine("_allSelectedTogether.Length = " + _allSelectedTogether.Length);
            _length = _randomNumber.Next(8, 16);
            while (_password.Length < _length)
            {
                _password += _allSelectedTogether[_randomNumber.Next(_allSelectedTogether.Length)];
            }
            Console.WriteLine(_password);
            return _password;
        }
    }
}
