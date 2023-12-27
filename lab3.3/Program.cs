Console.Write("Введите колличество циклов минимально 1: ");
double b = double.Parse(Console.ReadLine());
if(b == 1) { Console.Write("Число введено неверно"); Environment.Exit(1); }
Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
double c = 0;
for (int i = 0; i < b; i++ ){
    double d = 3; double s = 2;  
    c = Math.Acos(x);
    if(i == 0)
    {
        c = c + (Math.Acos(d * x)) / (d * d);
    }
    else
    {
        d = d + s;
        c = c + (Math.Acos(d * x)) / (d * d);
    }
}
Console.Write(c);