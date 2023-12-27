Console.Write("Введите число N>0: ");
int N = int.Parse(Console.ReadLine());
if (N < 0) { Console.Write("Число не может быть меньше 0"); Environment.Exit(1); }
double x = 2; double b = 0;
for(double i = 2; i < N+1; i++)
{
    if (i == 2){ b = x * (1 / i); }
    else { b = b * (1 / i); }
    
}

Console.Write($"x = {b}");