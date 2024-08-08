using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "The quick brown fox jumps over the lazy dog.";
            Text text = new Text(input);

            Console.WriteLine("Text: {0}", text);
            Console.WriteLine("Number of vowels: {0}", text.getVowelsNumber());
            Console.WriteLine("Number of consonants: {0}", text.getConsonantsNumber());
            Console.WriteLine("Number of spaces: {0}", text.getCharacterOf(' '));
            Console.WriteLine("Replacing spaces with #: {0}", text.replaceCharacter(' ', '#'));
        }
    }
}
