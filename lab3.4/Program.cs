double y = 0;
Console.WriteLine("|    x   |   y    |");
for (double x = -2; x <= 3; x += 0.2)
{
    if (x < 0)
    {
        
    }
    else if ((0 <= x) && (x <= 1))
    {
        y = y + 1;
    }
    else if (x > 1.5)
    {
        y = (2.5*Math.Pow(y, 3)) + (6*Math.Pow(y, 2) - 30);
    }
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");

}