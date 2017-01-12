using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReverseString.Models;

namespace ReverseString
{
    public class WordReverse
    {
        public String reverseWords(String s)
        {
            string[] words = s.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public String reverseWordLetters(String w)
        {
            char[] letters = w.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }

        static void Main(string[] args)
        {
            WordReverse wr = new WordReverse();
            String s = wr.reverseWords("hello world");
            Console.WriteLine(s);
            Console.ReadLine();

            String w = wr.reverseWordLetters("hello world");
            Console.WriteLine(w);
            Console.ReadLine();
        }
    }
}
