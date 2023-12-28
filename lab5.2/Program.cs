Console.Write("Введите строку: ");
string input = Console.ReadLine();
char[] charArray = input.ToCharArray();
for (int i = 0; i < input.Length - 1; i += 2)
{
    char temp = charArray[i];
    charArray[i] = charArray[i + 1];
    charArray[i + 1] = temp;
}
string result = new string(charArray);
Console.WriteLine("Результат: " + result);