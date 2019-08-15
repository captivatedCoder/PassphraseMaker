using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PassphraseMaker.Generators
{
    public static class WeakPassphraseGenerator
    {
        private static readonly StringBuilder Password = new StringBuilder();
        private static readonly RNGCryptoServiceProvider RngSeed = new RNGCryptoServiceProvider();
        private static readonly Random RandomDigit = new Random();

        public static string ReturnWeakPassword()
        {
            GetWord();
            GetDigits();
            GetSpecialCharacter();

            return Password.ToString();
        }

        private static void GetWord()
        {
            var randomNumber = new byte[1];
            RngSeed.GetBytes(randomNumber);

            //var passwordWord =
                //CsvDictionaries.PasswordList[randomNumber[0] % CsvDictionaries.PasswordList.Count];

            //passwordWord = char.ToUpper(passwordWord[0]) + passwordWord.Substring(1);

            //Password.Append(passwordWord);
        }

        private static void GetDigits()
        {
            var passwordDigits = new int[3];

            for (var i = 0; i <= 2; i++)
            {
                passwordDigits[i] = RandomDigit.Next(0, 9);
            }

            Password.Append(passwordDigits.Aggregate(string.Empty, (s, i) => s + i.ToString()));
        }

        private static void GetSpecialCharacter()
        {
            //var symbols = CsvSpecialCharacters.SpecialCharactersList;
            //var randomDigit = RandomDigit.Next(0, symbols.Length);
            //Password.Append(symbols[randomDigit]);
        }
    }
}
