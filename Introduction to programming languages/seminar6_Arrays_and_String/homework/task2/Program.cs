// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
using System;

class Program
{
    static void Main()
    {
        // Исходная строка с латинскими буквами в обоих регистрах
        string input = "Hello, World! This Is A Test String.";

        // Преобразование всех заглавных букв в строчные
        string result = input.ToLower();

        // Вывод результата
        Console.WriteLine(result);
    }
}
