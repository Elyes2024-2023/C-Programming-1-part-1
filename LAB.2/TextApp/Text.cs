using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextApp
{
    internal class Text
    {
        private string text;

        public Text(string text)
        {
            this.text = text;
        }

        public int getCharacterOf(char character)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == character)
                {
                    count++;
                }
            }
            return count;
        }

        public int getConsonantsNumber()
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c) && !"aeiouAEIOU".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int getVowelsNumber()
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c) && "aeiouAEIOU".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        public string replaceCharacter(char oldChar, char newChar)
        {
            return text.Replace(oldChar, newChar);
        }

        public override string ToString()
        {
            return text;
        }
    }
}
