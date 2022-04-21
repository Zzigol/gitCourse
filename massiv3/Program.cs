using System;

namespace mass;

static class Program
{
    static void Main(string[] args)

    {
        int sum = 0;

        Console.Write("Введите количество элементов массива:\t");
        int count = int.Parse(Console.ReadLine());
        int[] myArray = new int[count];
        //proverka gita

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}:\t");
            myArray[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i]%2 == 0) sum += myArray[i];

        }
        Console.WriteLine($"\nСумма четных чисел  = {sum}");
        Console.ReadLine();

    }
}