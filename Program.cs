using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_bottles_of_m0b
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(0, 100).Reverse().ToList().ForEach(i => new System.Speech.Synthesis.SpeechSynthesizer().Speak(string.Format(i > 0 ? "{0} bottles of beer on the wall, {0} bottles of beer.\nTake one down, pass it around, {1} bottles of beer on the wall..." : "No more bottles of beer on the wall, no more bottles of beer.", i, i - 1)));
        }
    }
}
