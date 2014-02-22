using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EncodeAndEncrypt
{
    static string Encode(string text)
    {
        var result = new StringBuilder();

        char previous = text[0];
        int counter = 1;
        for (int i = 1; i < text.Length; i++)
        {
            
            if (previous == text[i])
            {
                counter++;
            }
            else
            {
                if (counter == 1)
                {
                    result.Append(previous);
                }
                else if (counter == 2)
                {
                    result.Append(new string(previous, 2));
                }
                else
                {
                    result.Append(counter + previous.ToString());
                }
                counter = 1;
            }
            

            previous = text[i];
        }
                
        if (counter == 1)
        {
            result.Append(previous);
        }
        else if (counter == 2)
        {
            result.Append(new string(previous, 2));
        }
        else
        {
            result.Append(counter + previous.ToString());
        }

        return result.ToString();
    }
    static string Encrypt(string message, string cypher)
    { 
        string result = string.Empty;
        
        if (message.Length > cypher.Length)
        {
            result = EncryptionWhenMessageIsLonger(message, cypher);
        }
        else
        {
            result = EncryptionWhenCypherIsLonger(message, cypher);
        }

        return result;
    }
    static string EncryptionWhenMessageIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder();

        int cypherIndex = 0;

        for (int i = 0; i < message.Length; i++)
        {
            cypherIndex = i % cypher.Length;

            char messageSymbol = message[i];
            char cypherSymbol = cypher[cypherIndex];
            char encryptedSymbol = EncryptedSymbol(messageSymbol, cypherSymbol);

            result.Append(encryptedSymbol);

        }

        return result.ToString();
    }

    static char EncryptedSymbol(char messageSymbol, char cypherSymbol)
    {
        int messageSymbolCode = messageSymbol - 'A';
        int cypherSymbolCode = cypherSymbol - 'A';
        int xsored = messageSymbolCode ^ cypherSymbolCode;
        char result = (char)(xsored + 'A');
         
        return result;
    }
    static string EncryptionWhenCypherIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder(message);

        int messageIndex = 0;

        for (int i = 0; i < cypher.Length; i++)
        {
            messageIndex = i % message.Length;

            char messageSymbol = result[messageIndex];
            char cypherSymbol = cypher[i];
            char encryptedSymbol = EncryptedSymbol(messageSymbol, cypherSymbol);

            result[messageIndex] = encryptedSymbol;
        }

        return result.ToString();
    }

    
    static void Main()
    {
        //string test = Encrypt("ABCDE", "PQR");
        //string test2 = Encrypt("ABC", "PQRST");
        //Console.WriteLine(test);
        //Console.WriteLine(test2);

        string message = Console.ReadLine();
        string cypher = Console.ReadLine();

        int lengthOfCypher = cypher.Length;
        

        string result = Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher;

        Console.WriteLine(result);
    }
}

