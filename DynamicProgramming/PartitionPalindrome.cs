using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class PartitionPalindrome
    {
        public static int Count(string Word) {

            return subStringPalindrome(Word, 0, Word.Length - 1);
        }
        static int subStringPalindrome(string word,int start,int end) {
          // base condition
            if (start == end) return 0;
            if (IsPalindrome(word, start, end)) return 0;

            int currentPartion = int.MaxValue;
            for (int k=start;k<end;k++) {
                currentPartion = Math.Min(currentPartion,
                                        (1 + subStringPalindrome(word, start, k)
                                        + subStringPalindrome(word, k + 1, end)
                                        ));
            }
            return currentPartion;
        }    
        static bool IsPalindrome(string word, int Start,int end) {
            while (Start <= end && word[Start] == word[end]) {
                Start++;
                end--;
            }
            
            if (Start > end) {
                return true;
            }
            
            return false;
        }

       //Pending this topic is to be studied Later...
        private static void decomposeString(string word,int currentPostion,  List<List<string>> containers, List<string> container)
        {
            if (currentPostion == word.Length) {
                containers.Add(new List<string>(container));
            }

            for (int i = currentPostion; i < word.Length; i++) {
                if (IsPalindrome(word, currentPostion, i)) {
                    container.Add(word.Substring(currentPostion, i - currentPostion + 1));
                    decomposeString(word, i + 1, containers, container);
                    container.RemoveAt(container.Count - 1);
                }
            }
        }
    }
}
