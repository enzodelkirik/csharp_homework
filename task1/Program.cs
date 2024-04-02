/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        string? inputM = Console.ReadLine();
        if (int.TryParse(inputM, out int M))
        {
            Console.Write("Введите значение N: ");
            string? inputN = Console.ReadLine();
            if (int.TryParse(inputN, out int N))
            {
                PrintNaturalNumbers(M, N);
            }
            else
            {
                Console.WriteLine("Некорректное значение N. Пожалуйста, введите целое число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректное значение M. Пожалуйста, введите целое число.");
        }
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNaturalNumbers(start + 1, end);
        }
    }
}
