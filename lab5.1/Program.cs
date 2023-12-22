using System.Globalization;


Console.ForegroundColor = ConsoleColor.Red; Console.Write("Введите текст: "); Console.ResetColor();
string st1 = Console.ReadLine(); 
char[] ch1 = new char[st1.Length];
for(int j = 0; j < st1.Length; j++)
{
    ch1[j] = Convert.ToChar(st1[j]);
}
double ctr = 0;
for (int i = 0; i < ch1.Length; i++)
{
    UnicodeCategory category = UnicodeCategory.UppercaseLetter;
    if (char.GetUnicodeCategory(ch1[i]) == category) {  ctr++; }
}
double result = (ctr / st1.Length) * 100;
Console.WriteLine($"Процент заглавных букв в предложении: {result:F2}");