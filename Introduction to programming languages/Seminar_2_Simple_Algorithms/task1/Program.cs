// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 И 23
// Пример: 
// a=50 ⇒ нет
// a=7 ⇒ нет
// a=322 ⇒ да

Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }