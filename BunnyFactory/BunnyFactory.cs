using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BunnyFactory
{
    static void Main()
    {
        var cages = new List<int>();
        int i=0;

        while (true)
        {
            cages[i] = Console.ReadLine();
            i++;
        }


        Console.WriteLine(string.Join(" ",cages));



    }
}

