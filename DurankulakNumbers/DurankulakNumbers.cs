using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DurankulakNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        long sum = 0;
       
        for (int i = 0; i < input.Length; i++)
        {

            sum *= 168;
            if (input[i] > 96)
            {
                sum += 26 * (input[i] - 96);
                sum += input[i + 1] - 'A';
                i++;
            }
            else
            {
                sum += input[i] - 'A';
            }

        }

        Console.WriteLine(sum);

    }
}

