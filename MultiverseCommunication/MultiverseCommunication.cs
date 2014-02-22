using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        long sum = 0;
        string[] array = new string[] { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        //string[] array = new string[] {"Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };      
        for (int i = 0; i < input.Length; i+=4 )
        {
            for (int j = 0; j < array.Length; j++)
            {

                if (input.Substring(i , 4) == array[j])
                {

                    sum *= 15;
                    sum += j;
                   
                }
            }
        }
        Console.WriteLine(sum);

        
    }
}

