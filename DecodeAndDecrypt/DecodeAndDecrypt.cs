using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecodeAndDecrypt
{
    static void Main()
    {
        StringBuilder input =new StringBuilder(Console.ReadLine());
        var sbCypherLength = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] >= '0' && input[i]<= '9')
            {
                sbCypherLength.Insert(0, input[i]);
            }
            else
            {
                break;
            }
        }
        input.Remove(input.Length - sbCypherLength.Length, sbCypherLength.Length);
        int cypherLength = int.Parse(sbCypherLength.ToString());
        //Console.WriteLine(cypherLength);
        //Console.WriteLine(sbCypherLength.ToString());
        // Console.WriteLine(input.ToString());


        //Encrypt Length + cypher
        var sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] <= '9' && input[i] >= '0')
            {
                var sbInt = new StringBuilder();

                while (input[i] <= '9' && input[i] >= '0')
                {
                    sbInt.Append(input[i]);
                    i++;     
                }

                int repeat = int.Parse(sbInt.ToString());           
                sb.Append(input[i],repeat);		                                                       
               // Console.WriteLine(sbInt.ToString());                
            }
            else
            {
                sb.Append(input[i].ToString());
            }
        }
        
        //Console.WriteLine(sb.ToString());

        string cypher = sb.ToString().Substring(sb.ToString().Length - cypherLength, cypherLength);
        //Console.WriteLine(cypher);

        string encryptedMessege = sb.ToString().Substring(0, sb.ToString().Length - cypherLength);
        //Console.WriteLine(encryptedMessege);

        int maxLength = Math.Max(encryptedMessege.Length,cypher.Length);
           
        var result = new StringBuilder(encryptedMessege);

        for (int i = 0; i < maxLength; i++)
        {
            var messegeIndex = i % encryptedMessege.Length;
            var cypherIndex = i % cypher.Length;
            
            result[messegeIndex] = (char)((result[messegeIndex] - 'A' ^ (cypher[cypherIndex] - 'A')) + 'A');           
        }
        Console.WriteLine(result.ToString());        

    }
}

