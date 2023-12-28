Random rnd = new Random();
int[,] matrix = new int[7, 7];
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 7; j++)
    {

        matrix[i, j] = rnd.Next(-100,100);//заполнение массива
    }
}


int negativeCount = 0;
int rowLength = matrix.GetLength(0);// Поиск индексов второго отрицательного числа
int colLength = matrix.GetLength(1);
int secondNegativeRow = -1;
int secondNegativeCol = -1;

for (int row = 0; row < rowLength; row++)
{
    for (int col = 0; col < colLength; col++)
    {
        if (matrix[row, col] < 0)
        {
            negativeCount++;
            if (negativeCount == 2)
            {
                secondNegativeRow = row;
                secondNegativeCol = col;
            }
        }
    }
}

// Если не найдено второе отрицательное число, выводим сообщение об ошибке
if (secondNegativeRow == -1 || secondNegativeCol == -1)
{
    Console.WriteLine("В матрице отсутствуют два отрицательных числа.");
    return;
}

// Создание отсортированного списка элементов после второго отрицательного числа
int elementsCount = (rowLength * colLength) - ((secondNegativeRow * colLength) + secondNegativeCol + 1);
int[] sortedElements = new int[elementsCount];
int index = 0;

for (int row = secondNegativeRow; row < rowLength; row++)
{
    int startCol = (row == secondNegativeRow) ? secondNegativeCol + 1 : 0;
    for (int col = startCol; col < colLength; col++)
    {
        sortedElements[index] = matrix[row, col];
        index++;
    }
}


Array.Sort(sortedElements);// Сортировка элементов по убыванию
Array.Reverse(sortedElements);


Console.WriteLine("Отсортированные элементы после второго отрицательного числа: ");

for (int i = 0; i < elementsCount; i++)
{
    Console.Write(sortedElements[i] + " ");
}

Console.WriteLine();