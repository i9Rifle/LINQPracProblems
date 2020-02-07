using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac
{
    public class Word
    {
        public string word;
        public string thwords;
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        public void GetWords()
        {
            var wordscontainingth = words.Where(w => w.Contains("th"));
            foreach (var word in wordscontainingth)
            {
                Console.WriteLine(" ");
            }
        }
    }
}
