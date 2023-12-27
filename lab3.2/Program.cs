Console.Write("Введите минимальное число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int n = int.Parse(Console.ReadLine());
if(n < m) { Console.Write("Числа введены неправильно"); Environment.Exit(1); }
int b = 0;
for(; m < n+1; m++)
{
    b = (m*m) + b;
}
Console.Write(b);