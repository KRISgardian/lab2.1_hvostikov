Console.WriteLine("Красный зал - Хроники Нарнии\n    12ч - 25гр\n    16ч - 35гр\n    20ч - 45гр\nСиний зал - Чужие\n    10ч - 25гр\n    13ч - 35гр\n    16ч - 35гр\nГолубой зал - " +
    "Аватар\n    10ч - 35гр\n    14ч - 45гр\n    18ч - 45гр");
Console.Write("Введите название зала: "); string hall = Console.ReadLine().ToLower();
int time = 0;//время сеанса
double price = 0;//переменная для итоговой цены
int tickets = 0;//колличество билетов
//выясняем какой зал, дефолтом ловим ошибку ввода зала

switch (hall)
{
    case "красный зал":
        Console.Write("Введите время сеанса: "); time = int.Parse(Console.ReadLine());//узнаем время сеанса 
        if (time != 12 && time != 16 && time != 20) { Console.WriteLine("[ERROR] Время введено с ошибкой"); System.Environment.Exit(1); }//проверка на ошибки ввода времени сеанса
        else {; }
        Console.Write("Введите колличество билетов: "); tickets = int.Parse(Console.ReadLine());//берем колличество билетов
        if (time == 12) { price = tickets * 25; }//*************************
        else if (time == 16) { price = tickets * 35; }//вычисляем цену до скидок за колличество билетов
        else { price = tickets * 45; }//*************************
        if (tickets >= 5 && tickets < 10) { price = (price / 100) * 95; }//*************************
        else if (tickets >= 10) { price = (price / 100) * 90; }//вычисление скидки для билетов
        Console.WriteLine(price);
        break;
    case "синий зал":
        Console.Write("Введите время сеанса: "); time = int.Parse(Console.ReadLine());//узнаем время сеанса
        if (time != 10 && time != 13 && time != 16) { Console.WriteLine("[ERROR] Время введено с ошибкой"); System.Environment.Exit(1); }//проверка на ошибки ввода времени сеанса
        Console.Write("Введите колличество билетов: "); tickets = int.Parse(Console.ReadLine());//берем колличество билетов
        if (time == 10) { price = tickets * 25; }//*************************
        else if (time == 13) { price = tickets * 35; }//вычисляем цену до скидок за колличество билетов
        else { price = tickets * 35; }//*************************
        if (tickets >= 5 && tickets < 10) { price = (price / 100) * 95; }//*************************
        else if (tickets >= 10) { price = (price / 100) * 90; }//вычисление скидки для билетов
        else { price = price; }//*************************
        Console.WriteLine(price);
        break;
    case "голубой зал":
        Console.Write("Введите время сеанса: "); time = int.Parse(Console.ReadLine());//узнаем время сеанса
        if (time != 10 && time != 14 && time != 18) { Console.WriteLine("[ERROR] Время введено с ошибкой"); System.Environment.Exit(1); }//проверка на ошибки ввода времени сеанса
        Console.Write("Введите колличество билетов: "); tickets = int.Parse(Console.ReadLine());//берем колличество билетов
        if (time == 10) { price = tickets * 35; }//*************************
        else if (time == 14) { price = tickets * 45; }//вычисляем цену до скидок за колличество билетов
        else { price = tickets * 45; }//*************************
        if (tickets >= 5 && tickets < 10) { price = (price / 100) * 95; }//*************************
        else if (tickets >= 10) { price = (price / 100) * 90; }//вычисление скидки для билетов
        else { price = price; }//*************************
        Console.WriteLine(price);
        break;
    default:
        Console.WriteLine("Название введено неправильно");
        System.Environment.Exit(1);
        break;
}