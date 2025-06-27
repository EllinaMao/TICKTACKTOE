using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeCoderAndDecoder
{
    /*
    Cоздайте приложение для перевода обычного текста
    в азбуку Морзе. Пользователь вводит текст. Приложение
    отображает введенный текст азбукой Морзе. Используйте
    механизмы пространств имён.

    Задание 4
    Добавьте к предыдущему заданию механизм перевода
    текста из азбуки Морзе в обычный текст
    */
    internal static class MorzeCoderDecoder
    {
        public static string ToMorze(string input, Dictionary<char, string> dict)
        {

            StringBuilder morzeCode = new StringBuilder();
            input = input.ToUpper();
            foreach (var c in input)
            {
                if (dict.Keys.Contains(c))
                {
                    morzeCode.Append(dict[c] + " ");
                }
                else if (c == ' ')
                {
                    morzeCode.Append("   ");
                }
            }
            string result = morzeCode.ToString().Trim();
            return result;
        }

        public static string FromMorze(string input, Dictionary<char, string> dict)
        {
            StringBuilder regularText = new StringBuilder();
            var words = input.Trim().Split(new string[] { "   " }, StringSplitOptions.None);
            foreach (var word in words)
            {
                var letters = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var letter in letters)
                {
                    // Поиск символа по значению Морзе. Where менее эффективен, чем FirstOrDefault, так как нужен только первый найденный элемент
                    var match = dict.FirstOrDefault(kv => kv.Value == letter);
                    if (!match.Equals(default(KeyValuePair<char, string>)))
                    {
                        regularText.Append(match.Key);
                    }
                }
                regularText.Append(' ');
            }
            return regularText.ToString().ToLower().TrimEnd();
        }
    }
}
