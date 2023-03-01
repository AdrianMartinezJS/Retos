using System;

namespace Retos_Moure
{
    public class HackerLanguage
    {
        private Dictionary<char,string> _LeetLanguage = new Dictionary<char, string>
        {
            { 'A', "4" },
            { 'B', "I3" },
            { 'C', "[" },
            { 'D', ")" },
            { 'E', "3" },
            { 'F', "|=" },
            { 'G', "&" },
            { 'H', "#" },
            { 'I', "1" },
            { 'J', ",_|" },
            { 'K', ">|" },
            { 'L', "1" },
            { 'M', "/\\/\\" },
            { 'N', "^/" },
            { 'O', "0" },
            { 'P', "|*" },
            { 'Q', "(_,)" },
            { 'R', "I2" },
            { 'S', "5" },
            { 'T', "7" },
            { 'U', "(_)" },
            { 'V', "\\/" },
            { 'W', "\\/\\/" },
            { 'X', "><" },
            { 'Y', "j" },
            { 'Z', "2" },
            { '1', "L" },
            { '2', "R" },
            { '3', "E" },
            { '4', "A" },
            { '5', "S" },
            { '6', "b" },
            { '7', "T" },
            { '8', "B" },
            { '9', "g" },
            { '0', "o" },
            { ' ', " " }
        };
        public string transformStringToLeet(string text)
        {
            if(String.IsNullOrEmpty(text))
                return "Provide a normal Text!";

            var textAsArray = text.ToCharArray();
            var textAsLeefLanguage = "";

            foreach( char c in textAsArray )
            {
                textAsLeefLanguage += _LeetLanguage[char.ToUpper(c)];
            }

            return textAsLeefLanguage;
        }
    }
}
