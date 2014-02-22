using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MovingLetters
{
	static void Main()
	{
		string input = Console.ReadLine();
		char[] split = new char[] { ' ' };
		var allWords = new List<string>(input.Split(split,StringSplitOptions.RemoveEmptyEntries));

		int maxLength = 0;
		
		StringBuilder sb = new StringBuilder();

		for (int i = 0; i < allWords.Count; i++)
		{
			if (allWords[i].Length > maxLength)
			{
				maxLength = allWords[i].Length;
			}
		}
	   
		for (int i = 0; i < maxLength; i++)
		{
			foreach (var word in allWords)
			{
				if (word.Length > i % maxLength)
				{
					sb.Append(word[word.Length-1-i]);

				}
			}
		}
		
		int sequenceLength = sb.Length;   

		StringBuilder temp = new StringBuilder();
		int moveToPosition = 0;

		for (int i = 0; i < sequenceLength; i++)
		{
			if (sb[i] < 91)
			{
				moveToPosition = sb[i] - 64;
			}
			else
			{
				moveToPosition = sb[i] - 96; 
			}

			temp.Append(sb[i]);
			sb.Remove(i,1);
			sb.Insert((moveToPosition + i) % sequenceLength,temp);
			temp.Clear();
		}

		Console.WriteLine(sb.ToString());

	}
}

