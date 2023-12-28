void Main()
{

    List<FurnitureSalon> orders = new List<FurnitureSalon>();

    // Добавляем элементы в список
    orders.Add(new FurnitureSalon { OrderNo = 1, OrderDate = new DateTime(2022, 1, 10), CustomerName = "John Smith", CustomerAddress = "123 Main St", CompletionDays = 7, OrderCost = 1000 });
    orders.Add(new FurnitureSalon { OrderNo = 2, OrderDate = new DateTime(2022, 2, 15), CustomerName = "Jane Doe", CustomerAddress = "456 Elm St", CompletionDays = 5, OrderCost = 1500 });
    orders.Add(new FurnitureSalon { OrderNo = 3, OrderDate = new DateTime(2022, 2, 20), CustomerName = "Bob Johnson", CustomerAddress = "789 Oak St", CompletionDays = 10, OrderCost = 2000 });

    // Выводим список всех заказов
    Console.WriteLine("Список всех заказов:");
    foreach (var order in orders)
    {
        Console.WriteLine($"No заказа: {order.OrderNo}");
        Console.WriteLine($"Дата заказа: {order.OrderDate}");
        Console.WriteLine($"ФИО заказчика: {order.CustomerName}");
        Console.WriteLine($"Адрес заказчика: {order.CustomerAddress}");
        Console.WriteLine($"Срок выполнения в днях: {order.CompletionDays}");
        Console.WriteLine($"Стоимость заказа: {order.OrderCost}");
        Console.WriteLine();
    }

    // Вводим номер месяца
    Console.WriteLine("Введите номер месяца:");
    int month = int.Parse(Console.ReadLine());

    // Отображаем информацию о заказах, сделанных в указанном месяце
    Console.WriteLine($"Информация о заказах, сделанных в месяце {month}:");
    foreach (var order in orders)
    {
        if (order.OrderDate.Month == month)
        {
            Console.WriteLine($"No заказа: {order.OrderNo}");
            Console.WriteLine($"Дата заказа: {order.OrderDate}");
            Console.WriteLine($"ФИО заказчика: {order.CustomerName}");
            Console.WriteLine($"Адрес заказчика: {order.CustomerAddress}");
            Console.WriteLine($"Срок выполнения в днях: {order.CompletionDays}");
            Console.WriteLine($"Стоимость заказа: {order.OrderCost}");
            Console.WriteLine();
        }
    }
}
Main();
struct FurnitureSalon
{
    public int OrderNo;
    public DateTime OrderDate;
    public string CustomerName;
    public string CustomerAddress;
    public int CompletionDays;
    public decimal OrderCost;
}
