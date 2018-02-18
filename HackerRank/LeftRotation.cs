using System;
using System.Linq;
using System.Text;
namespace HackerRank
{
    public class LeftRotation
    {
        public LeftRotation()
        {
        }

        public void Run(){
            string holder;
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();
            var firstInputArray = firstInput.Split();
            var secondInputList = secondInput.Split().ToList();
            var numberOfRotation = Convert.ToInt32(firstInputArray[1]);

            while (numberOfRotation > 0)
            {
                holder = secondInputList[0];
                secondInputList.RemoveAt(0);
                secondInputList.Add(holder);
                numberOfRotation--;

            }

            StringBuilder result = new StringBuilder();
            foreach (string num in secondInputList)
            {
                result.Append(num + " ");
            }

            Console.WriteLine(result);
        }
    }
}
