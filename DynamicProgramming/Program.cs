using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var result = PartitionPalindrome.IsPalindrome("iti", 0, 2);
            var result = PartitionPalindrome.Count("geeks");
            List<List<string>> containers = new List<List<string>>();
            PartitionPalindrome.palindromeSubString("geeks", containers,
                new List<string>(), 0, "geeks".Length - 1);
            containers.ForEach(x => {
                x.ForEach(y =>
                {
                    Console.Write(y);
                });
                Console.WriteLine();
            });
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
