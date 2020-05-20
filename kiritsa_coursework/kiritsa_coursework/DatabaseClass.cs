using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiritsa_coursework
{
    class DatabaseClass
    {
        private Dictionary<string, string> lettersTransliteration = new Dictionary<string, string>
        {
            {"Щ", "SHCH"},
            {"щ", "shch"},
            {"ё", "yo"},
            {"ж", "zh"},
            {"ч", "ch"},
            {"ш", "sh"},
            {"ю", "yu"},
            {"я", "ya"},
            {"Ё", "YO"},
            {"Ж", "ZH"},
            {"Ч", "CH"},
            {"Ш", "SH"},
            {"Ю", "YU"},
            {"Я", "YA"},
            {"а", "a"},
            {"б", "b"},
            {"в", "v"},
            {"г", "g"},
            {"д", "d"},
            {"е", "e"},
            {"з", "z"},
            {"и", "i"},
            {"й", "j"},
            {"к", "k"},
            {"л", "l"},
            {"м", "m"},
            {"н", "n"},
            {"о", "o"},
            {"п", "p"},
            {"р", "r"},
            {"с", "s"},
            {"т", "t"},
            {"у", "u"},
            {"ф", "f"},
            {"х", "h"},
            {"ц", "c"},
            {"ъ", "j"},
            {"ы", "i"},
            {"ь", "'"},
            {"э", "e"},
            {"А", "A"},
            {"Б", "B"},
            {"В", "V"},
            {"Г", "G"},
            {"Д", "D"},
            {"Е", "E"},
            {"З", "Z"},
            {"И", "I"},
            {"Й", "J"},
            {"К", "K"},
            {"Л", "L"},
            {"М", "M"},
            {"Н", "N"},
            {"О", "O"},
            {"П", "P"},
            {"Р", "R"},
            {"С", "S"},
            {"Т", "T"},
            {"У", "U"},
            {"Ф", "F"},
            {"Х", "H"},
            {"Ц", "C"},
            {"Ъ", "J"},
            {"Ы", "I"},
            {"Ь", "J"},
            {"Э", "E"},
        };

        private Dictionary<string, string> lettersKeyboard = new Dictionary<string, string>
        {
            {"а", "f"},
            {"б", ","},
            {"в", "d"},
            {"г", "u"},
            {"д", "l"},
            {"е", "t"},
            {"ё", "`"},
            {"ж", ";"},
            {"з", "p"},
            {"и", "b"},
            {"й", "q"},
            {"к", "r"},
            {"л", "k"},
            {"м", "v"},
            {"н", "y"},
            {"о", "j"},
            {"п", "g"},
            {"р", "h"},
            {"с", "c"},
            {"т", "n"},
            {"у", "e"},
            {"ф", "a"},
            {"х", "["},
            {"ц", "w"},
            {"ч", "x"},
            {"ш", "i"},
            {"щ", "o"},
            {"ъ", "]"},
            {"ы", "s"},
            {"ь", "m"},
            {"э", "'"},
            {"ю", "."},
            {"я", "z"},
            {"А", "F"},
            {"Б", "<"},
            {"В", "D"},
            {"Г", "U"},
            {"Д", "L"},
            {"Е", "T"},
            {"Ё", "~"},
            {"Ж", ":"},
            {"З", "P"},
            {"И", "B"},
            {"Й", "Q"},
            {"К", "R"},
            {"Л", "K"},
            {"М", "V"},
            {"Н", "Y"},
            {"О", "J"},
            {"П", "G"},
            {"Р", "H"},
            {"С", "C"},
            {"Т", "N"},
            {"У", "E"},
            {"Ф", "A"},
            {"Х", "{"},
            {"Ц", "W"},
            {"Ч", "X"},
            {"Ш", "I"},
            {"Щ", "O"},
            {"Ъ", "}"},
            {"Ы", "S"},
            {"Ь", "M"},
            {"Э", "\""},
            {"Ю", ">"},
            {"Я", "Z"},
        };

        public Dictionary<string, string> LettersTransliteration
        {
            get
            {
                return lettersTransliteration;
            }
        }

        public Dictionary<string, string> LettersKeyboard
        {
            get
            {
                return lettersKeyboard;
            }
        }
    }
}
