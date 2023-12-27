using mainDll;
Console.WriteLine("  ^\ny2|\n  |\ny1--->\n  x1  x2");

Console.Write("Введите координаты x1: "); int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x2: "); int x2 = Convert.ToInt32(Console.ReadLine());
if (x1 >= x2) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] x1 cannot be greater than or equal to x2"); Console.ResetColor(); Environment.Exit(1); }
Console.Write("Введите координаты y1: "); int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: "); int y2 = Convert.ToInt32(Console.ReadLine());
if(y1 >= y2) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] y1 cannot be greater than or equal to y2"); Console.ResetColor(); Environment.Exit(1); }
//Заполнение класса
mainClass mainClass = new mainClass();
mainClass.X1 = x1; mainClass.X2 = x2; mainClass.Y1 = y1; mainClass.Y2 = y2;
mainClass.determinantFunction();



//Инициализация класса
class mainClass
{
    public int X1 {  get; set; }
    public int X2 { get; set; }
    public int Y1 { get; set; }
    public int Y2 { get; set; }
    

    public void determinantFunction()
    {
        int width = X2 - X1;
        int height = Y2 - Y1;
        Console.WriteLine(width * height);
        if (width == height) { Console.WriteLine("Прямоугольник - квадрат"); }
        else { Console.WriteLine("Прямоугольник - не квадрат"); }
        Environments.Main(width, height);
    }
   
}
