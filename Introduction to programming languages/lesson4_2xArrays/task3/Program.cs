// Считать с консоли строку, состоящую изцифр и латинских букв.
// Сформировать новую строку, состоящую избукв исходной строки.
void Main()
{
string str = Console.ReadLine();
string result = GetLettersFromStr(str);
Console.WriteLine(result);
}

string GetLettersFromStr(string s)
{
string letters = "";
foreach (char e in s)
{
	if (char.IsAsciiLetter(e) == true)
	{
		letters = letters + e;
	}
}
return letters;
}

Main();