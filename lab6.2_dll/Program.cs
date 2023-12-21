namespace moyaveselayaferma;

public class Cow
{
    public static int corn(double[,] mas)
    {
        double[] diag1 = new double[7];//две диагонали 
        double[] diag2 = new double[7];//две диагонали 
        //***************
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < 7; i++)
        {
            diag1[i] = mas[i, i];
              Console.WriteLine(diag1[i] + " [FIRST_DIAG]"); //вычисление значений главной диагонали
        }
        //***************
        Console.WriteLine();
        int temp1 = 0; int temp2 = 6;
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i < 7; i++)
        {       
            diag2[i] = mas[temp1, temp2];
            temp1 = temp1 + 1; temp2 = temp2 - 1;
            Console.WriteLine(diag2[i] + " [SECOND_DIAG]");//вычисление значений вторичной диагонали
        }
        //***************
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        for (int i = 0; i < 7; i++)
        {
            mas[i,i] = diag2[i];
            Console.WriteLine(mas[i, i] + " [NEW_FIRST_DIAG]");//заполнение главной диагонали вторичной
        }
        Console.ForegroundColor= ConsoleColor.Blue;
        //***************
        temp1 = 0; temp2 = 6;
        Console.WriteLine();
        for (int i = 0; i < 7; i++)
        {
            mas[temp1,temp2] = diag1[i];
            Console.WriteLine(mas[temp1,temp2] + " [NEW_SECOND_DIAG]");//заполнение вторичной диагонали главной
            temp1 = temp1 + 1; temp2 = temp2 - 1;
        }
        Console.ResetColor();
        //***************
        return 0;
    }
}