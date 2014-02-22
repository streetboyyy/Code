using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KaspichanNumbers
{
    static void Main()
    {
        ulong input =ulong.Parse(Console.ReadLine());
        var sb =new StringBuilder();

        ulong currentByte = 0;

        ulong reminderIn26 = 0;
        do
        {
            currentByte = input % 256;

            reminderIn26 = currentByte % 26;
            sb.Insert(0,(char)(reminderIn26 + 'A'));

            if (currentByte > 25)
            {
                sb.Insert(0,(char)(currentByte/26 + 96));
            }
                        
            input /= 256;
   
        } while (input > 0);
        
        Console.WriteLine(sb.ToString());
    }



}

