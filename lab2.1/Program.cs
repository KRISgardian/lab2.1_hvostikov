Console.Write("Время разговоров в минутах: ");
int dt = 0; dt = int.Parse(Console.ReadLine()); //время разговора в минутах
Console.Write("Введите страну для переговоров: ");
string country = Console.ReadLine(); //страна переговоров
Console.Write("Введите день недели: ");
string d = Console.ReadLine(); //день недели
double price = 0; //общая цена 
double s = 0; //цена за минуту
if (country.ToLower() == "россия" && (d.ToLower() == "суббота" || d == "воскресенье"))
{
    s = 0.95; //в россии цена 0.95
    price = s * dt; //цена без скидок
    price = price / 100 * 90; //цена со скидкой
    Console.WriteLine($"Цена в Росии со скидкой: {price:F2}");
}
else if (country.ToLower() == "россия" && (d.ToLower() != "суббота" || d != "воскресенье"))
{
    s = 0.95; //в россии цена 0.95
    price = s * dt;
    Console.WriteLine($"Цена в России без скидок: {price:F2}");
}
if (country.ToLower() == "украина" && (d.ToLower() == "суббота" || d == "воскресенье"))
{
    s = 0.35; //в украине цена 0.35
    price = s * dt; //цена без скидок
    price = price / 100 * 90; //цена со скидкой
    Console.WriteLine($"Цена на Украине со скидкой: {price:F2}");
}
else if (country.ToLower() == "украина" && (d.ToLower() != "суббота" || d != "воскресенье"))
{
    s = 0.35; //в украине цена 0.35
    price = s * dt;
    Console.WriteLine($"Цена на Украине без скидок: {price:F2}");
}