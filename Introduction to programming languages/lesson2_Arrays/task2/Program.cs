// Создать массив и заполнить его целыми числами от 1 до N 
// (N - произвольное натуральное число). 
// Вывести элементы массива на экран.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// n = n + 1;
int[] arr = new int[n];
for (int i = 0; i < n; i++)
//for (int i = 1; i < arr.Length; i++) //Альтернативыный вариант arr.length - где .length - функция длинны масисва arr
{
	arr[i] = i;
	Console.WriteLine($"{arr[i]} ");
	// Console.WriteLine(" ");
}

  