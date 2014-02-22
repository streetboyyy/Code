using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var words = new List<string>();
        int maxLength = 0;

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
            if (words[i].Length > maxLength)
            {
                maxLength = words[i].Length;
            }  
        }

        for (int i = 0; i < words.Count; i++)
        {
            int moveToPosition = words[i].Length % (n + 1); //2

            words.Insert(moveToPosition,words[i]);

            if (moveToPosition > i)
            {
                words.RemoveAt(i);
            }
            else
            {
                words.RemoveAt(i + 1);
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < maxLength; i++)
        {
            foreach (var word in words)
            {

                if (word.Length > i)
                {
                    sb.Append(word[i]);
                    //Console.Write(word[i]);
                }
            }
        }

        Console.WriteLine(sb.ToString());
    }
}

