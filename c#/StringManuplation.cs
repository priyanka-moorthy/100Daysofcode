using System;
using System.IO;

namespace str
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String to be modified");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter Match String");
            string matchString = Console.ReadLine();
            int matchStringLen = matchString.Length;

            int ipStrLength = inputString.Length;
            string temp = "";
            string resultString = "";

            for (int i = 0; i < ipStrLength; i++)
            {
                String currChar = inputString[i].ToString();

                if (i == 0)
                {
                    temp = currChar;
                }
                else if (i != ipStrLength - 1)
                {
                    if (temp.Contains(currChar) || temp == "")
                    {
                        temp = temp + currChar;
                    }
                    else
                    {
                        if (temp.Length == matchStringLen)
                        {
                            resultString = resultString + temp[0];
                            temp = "";
                            temp = currChar;

                        }
                        else
                        {
                            resultString = resultString + temp;
                            temp = "";
                            temp = currChar;
                        }

                    }
                }
                else
                {
                    if (temp.Contains(currChar))
                    {
                        temp = temp + currChar;
                    }
                    else
                    {
                        resultString = resultString + temp;
                        temp = currChar;
                    }
                    if (temp.Length == matchStringLen)
                    {
                        resultString = resultString + temp[0];

                    }
                    else
                    {
                        resultString = resultString + temp;
                    }
                }


            }

            Console.WriteLine("Output String: {0}", resultString);

        }
    }
}
