using System;
using System.Linq;
using System.Text;

namespace Crypto
{
    // класс обратимого шифрования
    public class Gronsfeld
    {
        static char ShiftChar(char c, int shift, bool isRussianAlphabet)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }

            char offset = isRussianAlphabet ? (char)(char.IsLower(c) ? 'а' : 'А') : (char)(char.IsLower(c) ? 'a' : 'A');
            return (char)((((c - offset + shift) + 32) % 32) + offset);
        }
        /// <summary> Ключ </summary>
        public string Key = "12345";

        // Метод для установки ключа
        public void SetKey(string newKey)
        {
            Key = newKey;
        }

        /// <summary> Зашифровать текст </summary>
        public string Crypt(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int shift = int.Parse(Key[i % Key.Length].ToString());
                result += ShiftChar(currentChar, shift, true);
            }
            return result;
        }

        /// <summary> расшифровать текст </summary>
        public string Decrypt(string text)
        /// <summary> Зашифровать текст </summary>
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int shift = int.Parse(Key[i % Key.Length].ToString());
                result += ShiftChar(currentChar, -shift, true);
            }
            return result;
        }
    }
}
