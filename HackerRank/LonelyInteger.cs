using System;
using System.Collections.Generic;
namespace HackerRank
{
    public class LonelyInteger
    {
        public LonelyInteger()
        {
        }

        public void Run()
        {
            var numberOfInteger = Console.ReadLine();
            var numberInput = Console.ReadLine();
            var numberArray = numberInput.Split();

            var numberCount = new Dictionary<string, int>();
            foreach (string number in numberArray)
            {
                if (numberCount.ContainsKey(number) == false)
                {
                    numberCount.Add(number, 1);
                }
                else
                {
                    numberCount[number]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in numberCount)
            {
                if(pair.Value % 2 != 0)
                {
                    Console.WriteLine(pair.Key);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
