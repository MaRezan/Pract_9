using System;

namespace Pract_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            int a = 0;
            int[,] mass1 = new int[8, 8];
            for (int i = 0; i < mass1.GetLength(0); i++)
            {
                for (int j = 0; j < mass1.GetLength(1); j++)
                {
                    if (a == 0)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                    }
                    mass1[i, j] = a;
                    Console.Write(mass1[i, j] + " ");
                }
                if (a == 0)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Task_2
            int[,] mass2 = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < mass2.GetLength(0); i++)
            {
                for (int j = 0; j < mass2.GetLength(1); j++)
                {
                    mass2[i, j] = random.Next(-100, 100);
                    Console.Write(mass2[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }

            //Task_3
            Console.WriteLine("Суммы каждой строки, поочередно сверху");
            int sum = 0;
            for (int i = 0; i < mass2.GetLength(0); i++)
            {
                for (int j = 0; j < mass2.GetLength(0); j++)
                {
                    sum += mass2[i, j];
                }
                Console.Write(sum + "\t");
                sum = 0;
            }

            //Task_4
            Console.WriteLine("\n\nПростые числа");
            for (int i = 0; i < mass2.GetLength(0); i++)
            {
                for (int j = 0; j < mass2.GetLength(0); j++)
                {
                    if (mass2[i, j] > 1)
                    {
                        bool d = true;
                        for (int b = 2; b <= mass2[i, j] / 2; b++)
                        {
                            if (mass2[i, j] % b == 0)
                            {
                                d = false;
                                break;
                            }
                        }
                        if (d)
                        {
                            Console.Write(mass2[i, j] + "\t");
                        }
                    }
                }
            }
        }
    }
}
