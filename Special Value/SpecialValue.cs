using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SpecialValue
{
    static int[] CurrentRowConvertToArray(string[] currentRow)
    {
        int[] currentRowInt = new int[currentRow.Length];
        
        for (int j = 0; j < currentRowInt.Length; j++)
        {
            currentRowInt[j] = int.Parse(currentRow[j]);
        }
        return currentRowInt;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] cells = new int[n][];

        for (int i = 0; i < n; i++)
        {
            char[] split = new char[] { ' ', ',' };
            string[] input = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries);

            cells[i] = CurrentRowConvertToArray(input);
        }

        //
        int bestSpecialValue = 0;
        int specialValue = 0;

        for (int i = 0; i < 1; i++)
        {
            
            int currentColunm = 0;
            int currentRow = 0;
            for (int j = currentColunm; j < cells[currentRow].Length;)
            {
                int path = 1;
                int currentSpecialValue = 0;
                bool[][] visited = new bool[n][];
                
                while (cells[currentRow][currentColunm] >= 0 && visited[currentRow][currentColunm] == false)
                {
                    path++;
                    visited[currentRow][currentColunm] = true;
                    currentColunm = cells[currentRow][currentColunm];
                    currentRow++;

                    if (currentRow == n-1)
                    {
                        currentRow = 0;
                    }
                   
                }

                specialValue = Math.Abs(cells[currentRow][currentColunm]);                
                currentSpecialValue = path+specialValue;                
                                               
                if (bestSpecialValue < currentSpecialValue)
                {
                    bestSpecialValue = currentSpecialValue;
                }

                currentColunm++;

                if (currentColunm == cells[currentRow].Length)
                {
                    break;
                }
            }


        }

        Console.WriteLine(bestSpecialValue);
    }
}

