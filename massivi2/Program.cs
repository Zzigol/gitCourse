using System;

namespace mass;

static class Program
{
    static void Main(string[] args)

    {
        Console.Write("Введите количество элементов массива:\t");
        int count = int.Parse(Console.ReadLine());
        int[] myArray = new int[count];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}:\t");
            myArray[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("\nОбратный массив №1");
        for (int i = myArray.Length-1; i >= 0; i--)
        {
            Console.Write(myArray[i]);

        }
        Console.WriteLine();
        Array.Reverse(myArray);
        Console.WriteLine("Обратный массив №2\n");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i]);

        }

        Console.ReadLine();

    }
}
