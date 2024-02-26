// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;

class Program
{
    static void Main()
    {
        // Создание и инициализация двумерного массива символов
        char[,] charArray = {
            { 'H', 'e', 'l', 'l', 'o' },
            { 'W', 'o', 'r', 'l', 'd' }
        };

        // Создание строки для хранения результатов
        string result = "";

        // Получение размеров массива
        int rows = charArray.GetLength(0); // Количество строк
        int cols = charArray.GetLength(1); // Количество столбцов

        // Перебор всех элементов двумерного массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Добавление текущего символа в строку
                result += charArray[i, j];
            }
        }

        // Вывод результата
        Console.WriteLine(result);
    }
}
