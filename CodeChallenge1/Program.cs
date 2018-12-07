using System;
using System.Collections.Generic;
using System.Linq;
namespace CodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //process into a list of numbers
            string list = args[0];

            //convert to list of numbers
            List<int> listOfNumbers = list.Split(',').Select(int.Parse).ToList();
            IEnumerable<int> listOfNumbers2 = list.Split(',').Select(int.Parse);
            listOfNumbers.Sort();
            
            var listCount = listOfNumbers.Count();
            Console.Write("{");
            Console.Write(listOfNumbers[0]);
            for (int i = 0; i < listCount-1; i++)
            {
                
                if (listOfNumbers[i] + 1 == listOfNumbers[i + 1])
                {
                    Console.Write(",");
                    Console.Write(listOfNumbers[i + 1]);
                }
                else
                {
                    Console.Write("}");
                    if (i < listCount)
                    {
                        Console.Write(",{");
                        Console.Write(listOfNumbers[i + 1]);
                    }                    
                }
                
            }
            Console.Write("}");
        }
    }
}
