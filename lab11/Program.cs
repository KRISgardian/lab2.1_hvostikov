



NeSportic spc = new NeSportic();
Console.Write("Введите фамилию: ");
spc.Familia = Console.ReadLine();
Console.Write("Введите число соревнований:");
spc.ChisloSorevnovaniy = int.Parse(Console.ReadLine());
Console.Write("Введите сумму мест: ");
spc.SummaMest = int.Parse(Console.ReadLine());
Console.Write("Введите true если занимал первое место, если нет введите false: ");
string b = Console.ReadLine();
if (b == "true") { spc.PervoeMesto = true; }
else if (b == "false") {  spc.PervoeMesto = false; }
spc.Nsp(); Console.ReadKey();

class NeSportic : Sportic
{
    public bool PervoeMesto { get; set; }
    public double Qp {  get; set; }
    public void Nsp()
    {
        Q = ChisloSorevnovaniy / SummaMest;
        if (PervoeMesto == true) { Qp = 1.5 * Q; }
        else if (PervoeMesto == false) { Qp = Q; }
        Console.Write($"Фамилия = {Familia}\nЧисло соревнований = {ChisloSorevnovaniy}\nСумма мест = {SummaMest}\nЗанимал ли первое место = {PervoeMesto}\nQ = {Q:F2}\nQp = {Qp:F2}");
    }

}

class Sportic
{
    public string ?Familia { get; set; }
    public double ChisloSorevnovaniy { get; set; }
    public double SummaMest {  get; set; }
    public double Q {  get; set; } 
}