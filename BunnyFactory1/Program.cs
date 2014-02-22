using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class BunnyFactory1
{
	static void Main(string[] args)
	{

        checked
        {
            string input = string.Empty;
            var array = new List<int>();

            while (true)
            {
                input = Console.ReadLine();
                if (input != "END")
                {
                    array.Add(int.Parse(input));
                }
                else
                {
                    break;
                }
            }
            int cyrcle = 1;
            do
            {
                int sum = 0;
                BigInteger multiply = 1;

                int sumOfCages = 0;

                var sb = new StringBuilder();


                if (cyrcle <= array.Count)
                {
                    for (int i = 0; i < cyrcle; i++)
                    {
                        sumOfCages += array[i];
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(" ", array));
                    break;
                }

                //array.Count > sumOfCages + cyrcle
                if (sumOfCages > array.Count - cyrcle)
                {
                    Console.WriteLine(string.Join(" ", array));
                    break;
                }
                else
                {
                    for (int i = cyrcle; i < sumOfCages + cyrcle; i++)
                    {

                        sum += array[i];
                        multiply *= (BigInteger)array[i];
                    }
                    // Sum append
                    for (int i = 0; i < sum.ToString().Length; i++)
                    {
                        string sumStr = sum.ToString();
                        sb.Append(sumStr[i]);
                    }
                    //Multiply append
                    for (int i = 0; i < multiply.ToString().Length; i++)
                    {
                        string multiplyStr = multiply.ToString();
                        sb.Append(multiplyStr[i]);
                    }

                    array.RemoveRange(0, cyrcle + (int)sumOfCages);
                    // Console.WriteLine(string.Join(" ", array));

                    for (int i = 0; i < sb.Length; i++)
                    {
                        array.Insert(i, sb[i] - 48);
                    }

                    // whitout 0 and 1
                    for (int i = 0; i < array.Count; i++)
                    {

                        if (array[i] == 0 || array[i] == 1)
                        {
                            array.RemoveAt(i);
                            if (i != 0)
                            {
                                i--;
                            }
                            else
                            {
                                while (array[i] == 0 || array[i] == 1)
                                {
                                    array.RemoveAt(i);
                                }
                            }

                        }

                    }

                }
                array.TrimExcess();
                cyrcle++;
            } while (true);
        }
	}
}
			 

	


