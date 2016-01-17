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
            Enumerable.Range(0, 100).Reverse().ToList().ForEach(i => new System.Speech.Synthesis.SpeechSynthesizer().Speak(i > 0 ? $"{i} bottles of beer on the wall, {i} bottles of beer.\nTake one down, pass it around, {i-1} bottles of beer on the wall..." : "No more bottles of beer on the wall, no more bottles of beer."));
        }
    }
}
