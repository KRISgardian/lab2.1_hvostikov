string BinarySum(string binary1, string binary2)
{
    string result = "";

    int carry = 0; // перенос
    int i = binary1.Length - 1; // указатель на последний символ первого числа
    int j = binary2.Length - 1; // указатель на последний символ второго числа

    // Пока есть цифры для сложения
    while (i >= 0 || j >= 0)
    {
        // Получение текущих цифр чисел
        int bit1 = (i >= 0) ? binary1[i] - '0' : 0;
        int bit2 = (j >= 0) ? binary2[j] - '0' : 0;

        // Вычисление суммы текущих цифр
        int sum = bit1 + bit2 + carry;

        // Вычисление значения текущего бита в результирующем числе
        result = (sum % 2) + result;

        // Вычисление значения переноса
        carry = sum / 2;

        // Переход к следующим битам
        i--;
        j--;
    }

    // Если остался перенос, добавляем его к результату
    if (carry > 0)
    {
        result = carry + result;
    }

    return result;
}

void Main()
{
    // Ввод двоичных чисел
    Console.Write("Введите положительное двоичное число: ");
    string positiveBinary = Console.ReadLine();

    Console.Write("Введите отрицательное двоичное число: ");
    string negativeBinary = Console.ReadLine();

    // Вычисление суммы чисел
    string sum = BinarySum(positiveBinary, negativeBinary);

    // Вывод результата
    Console.WriteLine("Сумма: " + sum);

    Console.ReadLine();
}
Main();