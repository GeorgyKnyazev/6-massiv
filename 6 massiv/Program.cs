using System;

namespace _6_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxRandomNamber = 100;
            int minRandomNamber = 10;
            int minNumberInArray = int.MaxValue;
            int numberOrderInArray = 0;
            int[] userInputArray = new int[30];
            int[] firstTempArray = new int[userInputArray.Length];
            

            Random random = new Random();

            for (int i = 0; i < userInputArray.Length; i++)
            {
                userInputArray[i] = random.Next(minRandomNamber,maxRandomNamber);
                if(userInputArray[i] < minNumberInArray)
                {
                    minNumberInArray = userInputArray[i];
                }
                Console.Write(userInputArray[i] + " ");
            }

            while(numberOrderInArray < userInputArray.Length)
            {
                
                int numberRepitInArray = 0;

                for (int i = 0; i < userInputArray.Length; i++)
                {
                    if (userInputArray[i] == minNumberInArray)
                    {
                        numberRepitInArray++;
                    }
                }
                if (numberRepitInArray != 0)
                {
                    for (int i = 0; i < numberRepitInArray; i++)
                    {
                        firstTempArray[numberOrderInArray] = minNumberInArray;
                        numberOrderInArray++;
                    }
                }
                minNumberInArray++;
            }

            Console.WriteLine();

            for (int i = 0; i < firstTempArray.Length; i++)
            {
                Console.Write(firstTempArray[i] + " ");
            }
        }
    }
}
