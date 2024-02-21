// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Инициализация и заполнение массива
        int[] array = new int[10];
        Random random = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000); // Для примера используем трехзначные числа
            Console.Write(array[i] + " ");
        }

        // Переворачиваем массив
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }

        Console.WriteLine("\nПеревернутый массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}
