using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreedyDwarf
{
    static void Main()
    {
        char[] split = new char[] { ' ', ',' };
        string[] realValley = Console.ReadLine().Split(split,StringSplitOptions.RemoveEmptyEntries);

        int m = int.Parse(Console.ReadLine());

        int maxSum = int.MinValue;

        for (int i = 0; i < m; i++)
        {
            string[] pattern = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries);
            string[] valley = new string[realValley.Length];
            Array.Copy(realValley, valley, realValley.Length);

            int currentSum = int.Parse(valley[0]);
            int valleyIndex = 0;
            int patternCounter = 0;
            do
            {
                valleyIndex += int.Parse(pattern[patternCounter % pattern.Length]);

                if (valleyIndex > 0 && valleyIndex < valley.Length && valley[valleyIndex] != null )
                {
                    currentSum += int.Parse(valley[valleyIndex]);
                    valley[valleyIndex] = null;
                }
                else
                {
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    break;
                }

                patternCounter++;
            } while (true);            
        }

        Console.WriteLine(maxSum);


   

    }
}

