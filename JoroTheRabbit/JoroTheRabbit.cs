using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoroTheRabbit
{
	static void Main()
	{
		char[] split = new char[] {' ',','};
		string[] terrainNumbers = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[terrainNumbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(terrainNumbers[i]);
        }

        int bestPath = 1;
        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int step = 1; step < numbers.Length; step++)
            {
                int currentPath = 1;
                int index = startIndex;
                int next = (index + step);

                if (next >= numbers.Length)
	            {
                    next -= numbers.Length;
	            }
                //int next = (index + step) % numbers.Length;

                while (numbers[index] < numbers[next])
                {
                    currentPath++;
                    index = next;
                    next = (index + step);
                    if (next >= numbers.Length)
                    {
                        next -= numbers.Length;
                    }
                    //next = (index + step) % numbers.Length;
                    
                }

                if (currentPath > bestPath)
                {
                    bestPath = currentPath;
                }

            }

            
        }

        Console.WriteLine(bestPath);



	}
}

