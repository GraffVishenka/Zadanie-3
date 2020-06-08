using System;
using static System.Console;
using static System.Convert;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Выберете номер задания: \n1 \n2 \n3");
            int n = ToInt32(ReadLine());
            if (n == 1)
            {
                int[] mas = new int[5] { 3, 4, -9, -2, 5 };
                int ds = mas[0];
                int v = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (Math.Abs(mas[i]) < ds)
                    {
                        ds = Math.Abs(mas[i]);
                        v = i;
                    }
                }
                WriteLine($"Минимальное число: {ds} и его индекс: {v}");
            }
            else if (n == 2)
            {
                int[] mas = new int[10] { 1, 11, 5, 2, -7, 11, 9, 5, 6, -1 };
                string lol = "";
                int count = 0;

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas.Length; j++)
                    {
                        if (mas[i] == mas[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1) lol = lol + mas[i] + "; ";
                    count = 0;
                }
                WriteLine("Уникальные элементы массива: " + lol);
            }
            else if (n == 3)
            {
                int[] mas = new int[10];
                Random rand = new Random();
                WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    mas[i] = rand.Next(-10, 10);
                    Write(mas[i] + " ");
                }
                Write("\nПоложительные элементы массива: ");
                for (int i = 0; i < 10; i++)
                {
                    if (mas[i] < 0)
                    {
                        mas[i] = 0;
                    }
                    else Write(mas[i] + " ");
                }
            }
        }
    }
}
