using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringProblems;

namespace Algortitham
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PatternMatching.PreifxSuffix("aabcdaabc")
                .ToList().ForEach(x=> {
                    Console.WriteLine(x);
                });

            Console.ReadKey();
            
            string text = "THISISATESTTEXT";
            string pattern = "TEST";
            Console.WriteLine($"kmp algoritham {PatternMatching.KMP(text, pattern)}");
            Console.WriteLine($"Rabing karph Algoritham{PatternMatching.RabinKarp(text, pattern)}");
            Console.ReadLine();
             var solution=  slidingWindowTechnique.largestUniqueSubstring("geeksforgeeks");
            Console.WriteLine(solution);
            Console.ReadLine();
            */
            var solution = slidingWindowTechnique.longestSubstringwithKRepeatingCharacter("aaabb", 3);
            Console.WriteLine(solution);
            Console.ReadLine();

        }
    }
}
