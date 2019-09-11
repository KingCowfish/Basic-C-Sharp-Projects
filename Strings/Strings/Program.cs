using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string words1 = "I have a lovely ";
            string words2 = "bunch of ";
            string words3 = "coconuts!  ";

            string sentence = words1 + words2 + words3;
            Console.WriteLine(sentence);
            sentence = sentence.ToUpper();
            Console.WriteLine(sentence);

            StringBuilder add = new StringBuilder(sentence);
            add.Append("\nThere they are, all standing in a row.");
            add.Append("\nBig ones, small ones, some as big as yer 'ead!");
            add.Append("\nGive 'em a twist, a flick o' the wrist,");
            add.Append("\nThat's what the showman said.");
            Console.WriteLine(add);
            Console.ReadLine();

        }
    }
}
