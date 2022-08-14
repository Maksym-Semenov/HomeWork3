using System;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            int countLetters = 0;
            foreach (char item in text)
            {
                switch (item)
                {
                    case 'a':
                    case 'o':
                    case 'i':
                    case 'e': 
                        countLetters++; 
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"There are {countLetters} letters A O I E in this text");
            Console.ReadLine();

            //Part 2
            Console.WriteLine("Enter the number of month");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month have 31 days"); break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month have 30 days"); break;
                case 2:
                    Console.WriteLine("Enter year");
                    int year = int.Parse(Console.ReadLine());
                    if (year % 4 == 0)
                    {
                        if (year % 100 == 0)
                        {
                            if (year % 400 == 0)
                            {
                                Console.WriteLine("This month have 29 days");
                            }
                            else
                                Console.WriteLine("This month have 28 days");
                        }
                        else
                            Console.WriteLine("This month have 28 days");
                    }
                    else
                        Console.WriteLine("This month have 28 days");
                    break;
                default:
                    break;
            }

            //Part 3
            int[] arr = new int[10];
            bool isValuePositive = true;
            int sumFirstFifthValues = 0;
            int multiLastFifthValues = 1;

            Console.WriteLine("Enter 10 integer numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in arr)
            {
                if (item < 0)
                {
                    isValuePositive = false;
                }
            }
                if (isValuePositive)//Почему не true?
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        sumFirstFifthValues += arr[i];
                    }
                    Console.WriteLine($"Sum first fifth value = {sumFirstFifthValues}, " +
                                     $"because there aren't negative values");
            }
                else
                {
                    for (int i = 5; i < arr.Length; i++)
                    {
                        multiLastFifthValues *= arr[i];
                    }
                    Console.WriteLine($"Multiplication last fifth value =  {multiLastFifthValues}, " +
                                     $"because there are negative values");
                }
            Console.ReadLine();
        }
    }
}
