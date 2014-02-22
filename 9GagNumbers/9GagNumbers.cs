using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GagNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        var array = new string[] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

        ulong sum = 0;
        var sb = new StringBuilder();
        
        //!!**!- -! !-   = 653
        for (int i = 0; i < input.Length; i++)
        {
            
            sb.Append(input[i]);

            for (int j = 0; j < array.Length; j++)
            {
                if (sb.ToString() == array[j])
                {

                    sum *= 9;
                    sum += (ulong)j;
                    sb = new StringBuilder();

                }
            }

        }

        Console.WriteLine(sum);
    }
}

