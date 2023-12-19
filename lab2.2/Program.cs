Console.Write("Введите трехзначное число: ");
int b = int.Parse(Console.ReadLine());//введенное число
Console.Write("Введите число b: ");
int n = int.Parse(Console.ReadLine());//число b
int b3 = b % 10;//третья цифра
int b2 = ((b % 100) - b3) / 10;//вторая цифра
int b1 = (b - (b2 + b3)) / 100;//первая цифра
int v = b1 * b2 * b3;//произведение цифр числа
if (v > n) { Console.WriteLine("Произведение цифр больше b"); }
else if (v == n) { Console.WriteLine("Произведение цифр равно b"); }
else { Console.WriteLine("Произведение цифр меньше b"); }
v = (b1 + b2 + b3) % 3;
if (v != 0) { Console.WriteLine("Сумма цифр кратна 3"); Console.ReadKey(); }
else { Console.WriteLine("Сумма цифр не кратна 3"); Console.ReadKey(); }