using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeDictionary
{
    internal struct DictionaryEnglMorze
    {
        public Dictionary<char, string> MorzeCode { get; private set; }

        public DictionaryEnglMorze()
        {
            MorzeCode = new Dictionary<char, string>
            {
                {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
                {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
                {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
                {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
                {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
                {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
                {'Y', "-.--"}, {'Z', "--.."},
                // Digits
                {'0', "-----"}, {'1', ".----"}, {'2', "..---"},
                {'3', "...--"}, {'4', "....-"}, {'5', "....."},
                {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
                {'9', "----."},     
                // Punctuation
                {',', "--..--"}, {'.', ".-.-.-"}, {'?', "..--.."},
                {'!', "-.-.--"}, {'-', "-....-"}, {'/', "-..-."},
                {'(', "-.--."}, {')', "-.--.-"}, {'"', ".-..-."},
                {':', "---..."}
            };

        }
    }
}
