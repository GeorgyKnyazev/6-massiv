using System;

namespace _6_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxRandomNamber = 100;
            int minRandomNamber = 10;
            int[] userInputArray = new int[30];
            Random random = new Random();

            for (int i = 0; i < userInputArray.Length; i++)
            {
                userInputArray[i] = random.Next(minRandomNamber, maxRandomNamber);
                Console.Write(userInputArray[i] + " ");
            }

            
            for (int i = 0; i < userInputArray.Length; i++)
            {
                int minNumberInArray = int.MaxValue;
                int numberOrderInArray = 0;
                int tempNumber;

                for (int j = i; j < userInputArray.Length; j++)
                {
                    if(userInputArray[j] < minNumberInArray)
                    {
                        minNumberInArray = userInputArray[j];
                        numberOrderInArray = j;
                    }
                    else
                    {
                        continue;
                    }
                }
                tempNumber = userInputArray[i];
                userInputArray[i] = minNumberInArray;
                userInputArray[numberOrderInArray] = tempNumber;
            }
            

            Console.WriteLine();

            for (int i = 0; i < userInputArray.Length; i++)
            {
                Console.Write(userInputArray[i] + " ");
            }
        }
    }
}
