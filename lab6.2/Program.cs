using moyaveselayaferma;

double[,]? mas = new double[7,7];//делаем массив
Random rnd = new Random();//делаем рандом класс 
//****************
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < 7; i++) 
    for(int j = 0; j < 7; j++)
    {
        mas[i,j] = rnd.Next(1,9);//наполнение массива
        Console.Write(mas[i, j] + " "); 

    }
//****************
Console.Write(" [INPUT_MATRIX]");
Console.ResetColor();
Console.WriteLine();
Cow.corn(mas);//вызов .dll функции 
Console.ReadKey();