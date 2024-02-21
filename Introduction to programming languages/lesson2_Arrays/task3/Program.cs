// Создать целочисленный массив на 10 элементов и заполнить его произвольными числами. Вывести на экран чётные элементы массива.
// Пример 1
// Массив: [15 469 3 2 5 4 1]
// Чётные: 4 6 2 4
// Пример 2
// Массив: [9 5 1 7 15 36 3 1 1 71
// Чётные : 36

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
//for (int i = 1; i < arr.length; i++) //Альтернативыный вариант arr.length - где .length - функция длинны масисва arr
{
	if (i % 2 == 0)
	{
		arr[i] = i;
		Console.WriteLine($"{arr[i]} ");
	}
	else
	{
		arr[i] = i;
	}
	// Console.WriteLine(" ");
}
