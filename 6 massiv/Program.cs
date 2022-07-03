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
            int[] userInputArray = new int[30];
            int[] firstTempArray = new int[0];
            

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

            while(firstTempArray.Length < userInputArray.Length)
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
                        int[] secondTempArray = new int[firstTempArray.Length + 1];

                        for (int j = 0; j < firstTempArray.Length; j++)
                        {
                            secondTempArray[j] = firstTempArray[j];
                        }

                        secondTempArray[secondTempArray.Length - 1] = minNumberInArray;
                        firstTempArray = secondTempArray;
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
