using System;
using System.Collections.Generic;
namespace HackerRank
{
    public class RansomNote
    {
        public RansomNote()
        {
        }

        public void Run()
        {
            var wordCount = Console.ReadLine().Split();
            var magazineWords = Console.ReadLine().Split();
            var ransomNote = Console.ReadLine().Split();
            Dictionary<string, int> wordCounter = new Dictionary<string, int>();

            if (Convert.ToInt32(wordCount[0]) < Convert.ToInt32(wordCount[1]))
            {
                Console.WriteLine("No");
                return;
            }

            foreach (string word in magazineWords)
            {
                if (wordCounter.ContainsKey(word) == true)
                {
                    wordCounter[word]++;
                }
                else
                {
                    wordCounter.Add(word, 1);
                }
            }

            foreach (string word in ransomNote)
            {
                if (wordCounter.ContainsKey(word) == false)
                {
                    Console.WriteLine("No");
                    return;
                }

                wordCounter[word]--;
            }

            foreach (KeyValuePair<string, int> pair in wordCounter)
            {
                if (pair.Value < 0)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
