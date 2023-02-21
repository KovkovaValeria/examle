//В тексте нужно заменить пробелы черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с"
string text = "- Я думаю, - Сказал князь, улыбаяСь, - что";

string Replase(string text, char oldValue, char newValue)
{
	string result = String.Empty;
	int length = text.Length;
	for (int i = 0; i < length; i++)
	{
		if (text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}
string newText = Replase(text, ' ', '/');
Console.WriteLine(newText);
Console.WriteLine();

string nowText = Replase(newText, 'к', 'К');
Console.WriteLine(nowText);
Console.WriteLine();

string nywText = Replase(nowText, 'С', 'с');
Console.WriteLine(nywText);
Console.WriteLine();