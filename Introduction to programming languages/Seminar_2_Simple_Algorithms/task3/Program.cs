// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка (10, 99) и показывает наибольшую цифру числа.
// Пример:
// 40  ⇒ 4
// 96 ⇒ 9
// 72  ⇒ 7

Console.Write("Введите целое число из отрезка (10, 99): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10 && number < 99)
  {
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
      {
        Console.WriteLine(firstDigit);
      }
    else
      {
        Console.WriteLine(secondDigit);
      }
  }
else
  {
    Console.WriteLine("Число не входит в заданный отрезок.");
  }