// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        // Преобразование строки в нижний регистр и удаление всех не буквенно-цифровых символов
        string processedInput = "";
        foreach (char c in input.ToLower())
        {
            if (char.IsLetterOrDigit(c))
            {
                processedInput += c;
            }
        }

        // Проверка на палиндром
        int left = 0;
        int right = processedInput.Length - 1;
        while (left < right)
        {
            if (processedInput[left] != processedInput[right])
            {
                return false; // Строка не является палиндромом
            }
            left++;
            right--;
        }

        return true; // Строка является палиндромом
    }

    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);
        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }
}
