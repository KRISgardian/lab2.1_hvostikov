Console.WriteLine("  ^\ny2|\n  |\ny1--->\n  x1  x2");
Console.Write("Введите координаты x1: "); int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x2: "); int x2 = Convert.ToInt32(Console.ReadLine());
if (x1 >= x2) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] x1 cannot be greater than or equal to x2"); Console.ResetColor(); Environment.Exit(1); }
Console.Write("Введите координаты y1: "); int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: "); int y2 = Convert.ToInt32(Console.ReadLine());
if (y1 >= y2) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[ERROR] y1 cannot be greater than or equal to y2"); Console.ResetColor(); Environment.Exit(1); }
Console.Write("Укажите цвет закрашивания синий, зеленый или красный: ");
string color = Console.ReadLine();
Console.Write("Введите текст для прямоугольника: ");
string text = Console.ReadLine();
//Заполнение класса
Child mainClass = new Child();
mainClass.X1 = x1; mainClass.X2 = x2; mainClass.Y1 = y1; mainClass.Y2 = y2; mainClass.Color = color; mainClass.Text = text;

mainClass.main();








class Child : mainClass
{
    public string Color {  get; set; }
    public string Text { get; set; }
    public double diag {  get; set; }
    public int perim {  get; set; }
    public void main()
    {
        int x = determinantFunction();
        diag = Math.Sqrt(Math.Exp(height) * Math.Exp(width));
        perim = (width*2) + (height*2);
        if(Color == "синий")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (Color == "красный")
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (Color == "зеленый")
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        if (x == 1)
        {
            
            Console.WriteLine($"#####\n#####\n#####"); Console.ResetColor();
            Console.Write($"text = {Text}\ncolor = {Color}\nperimetr = {perim}\ndiagonal = {diag:F2}\nx1 = { X1}\nx2 = { X2}\ny1 = { Y1}\ny2 = { Y2}");
        }
        else if (x == 0)
        {

            Console.WriteLine($"########\n########\n########"); Console.ResetColor();
            Console.Write($"text = {Text}\ncolor = {Color}\nperimetr = {perim}\ndiagonal = {diag:F2}\nx1 = {X1}\nx2 ={X2}\ny1 ={Y1}\ny2 ={Y2}");
        }
        Console.ReadKey();
    }

}

class mainClass //класс родитель
{
    public int X1 { get; set; }
    public int X2 { get; set; }
    public int Y1 { get; set; }
    public int Y2 { get; set; }
    public int width {  get; set; }
    public int height { get; set; }
    public int determinantFunction()
    {
        width = X2 - X1;
        height = Y2 - Y1;
        int cube = 0;
        Console.WriteLine(width * height);
        if (width == height) { Console.WriteLine("Прямоугольник - квадрат"); cube = 1; return cube; }
        else { Console.WriteLine("Прямоугольник - не квадрат"); cube = 0; return cube; }
        
    }
}