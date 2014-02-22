using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TRES4Numbers
{
    static void Main(string[] args)
    {
        ulong input =ulong.Parse (Console.ReadLine());
        var array = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

        var sb = new StringBuilder();

        ulong reminer = 0;

        do
        {
            reminer = input % 9;
            for (int i = 0; i < array.Length; i++)
            {
                if (reminer == (ulong)i)
                {
                    sb.Insert(0,array[i]);
                }
            }
            input /= 9;

        } while (input > 0);
        

        Console.WriteLine(sb.ToString());
    }
}

;