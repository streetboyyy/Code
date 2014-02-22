using System;
using System.Collections.Generic;

class Zerg
{
    static void Main()
    {
        string input = Console.ReadLine();
        var array = new List<string>() { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
        //Rrrr Grrr
        long sum = 0;
        for (int i = 0; i < input.Length; i+=4)
        {
            var digitIn15 = input.Substring(i, 4);

            var decimalValue = array.IndexOf(digitIn15);

            sum *= 15;
            sum += decimalValue;
        }
        Console.WriteLine(sum);
    }
}

