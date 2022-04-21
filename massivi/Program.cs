using System;

namespace mass;

    static class Program
{ 
    static void Main(string[] args)

    {
        Console.Write("Введите количество элементов массива:\t");
        int count = int.Parse(Console.ReadLine());
        string[] myArray= new string [count];
        Console.WriteLine("Введите элемент массива");
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i]=Console.ReadLine();
            
        }
        Console.Write("Вывод массива:\t");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i]);

        }
                Console.ReadLine();

    }
}

