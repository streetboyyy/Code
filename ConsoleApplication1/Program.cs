using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix =new  int[n,n];
            string[] inputLine = new string[n];

            for (int i = 0; i < n; i++)
            {
                inputLine = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                     matrix[i,j] = int.Parse(inputLine[j]) ;
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine("NO {0}",sum);






        }
    }
}
