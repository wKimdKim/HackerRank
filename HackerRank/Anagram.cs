using System;
using System.Collections.Generic;
namespace HackerRank
{
    public class Anagram
    {
        public Anagram()
        {
        }

        public void Run()
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var offset = (int)Convert.ToChar("a");
            var result = 0;

            var recordArray = new int[26];

            foreach (char character in input1)
            {
                var letterAsc = (int)character;
                var index = letterAsc - offset;
                recordArray[index]++;

            }

            foreach (char character in input2)
            {
                var letterAsc = (int)character;
                var index = letterAsc - offset;
                recordArray[index]--;

            }

            foreach (int number in recordArray)
            {
                result += Math.Abs(number);
            }

            Console.WriteLine(result);

        }
    }
}
