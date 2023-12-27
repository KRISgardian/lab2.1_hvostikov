int b = 456;
int b3 = b % 10;//третья цифра
int b2 = ((b % 100) - b3) / 10;//вторая цифра
int b1 = (b - (b2 + b3)) / 100;//первая цифра
string b4 = Convert.ToString(b3);//вторая цифра числа х
string b5 = Convert.ToString(b2);//третья цифра числа х
string b6 = Convert.ToString(b1);//первая цифра числа ъ
string b7 = b6 + b4 + b5;
Console.Write(b7); Console.ReadKey();