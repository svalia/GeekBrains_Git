// Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void Main()
    {
        int M = ReadAndConvert("Введите значение M: ");
        int N = ReadAndConvert("Введите значение N: ");

        Console.WriteLine($"Натуральные числа от {M} до {N}:");
        PrintNumbers(M, N);
    }

  // int ReadAndConvert(string message)
  //   {
  //       Console.Write(message);
  //       return int.Parse(Console.ReadLine());
  //   }
	
	int ReadAndConvert(string message)
{
    Console.Write(message);
    string input = Console.ReadLine() ?? "0"; // Если введено null, используем "0" как значение по умолчанию
    return int.Parse(input);
}

  void PrintNumbers(int M, int N)
    {
        if (M > N)
        {
            return; // Если M больше N, рекурсия прекращается.
        }
        Console.WriteLine(M);
        PrintNumbers(M + 1, N); // Рекурсивный вызов функции с увеличенным M.
    }

		Main();

