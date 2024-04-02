/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/

using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(array, size - 1);
    }
}
