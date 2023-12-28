void Main()
{
    Player[] players = new Player[5];

    players[0] = new Player
    {
        LastName = "Smith",
        DateOfBirth = new DateTime(2000, 1, 1),
        Club = "Club A",
        Position = "Defender",
        GamesPlayed = 50,
        BirthPlace = "City A"
    };

    players[1] = new Player
    {
        LastName = "Johnson",
        DateOfBirth = new DateTime(2001, 2, 2),
        Club = "Club B",
        Position = "Defender",
        GamesPlayed = 30,
        BirthPlace = "City B"
    };

    players[2] = new Player
    {
        LastName = "Williams",
        DateOfBirth = new DateTime(2002, 3, 3),
        Club = "Club A",
        Position = "Midfielder",
        GamesPlayed = 60,
        BirthPlace = "City C"
    };

    players[3] = new Player
    {
        LastName = "Brown",
        DateOfBirth = new DateTime(2003, 4, 4),
        Club = "Club B",
        Position = "Defender",
        GamesPlayed = 45,
        BirthPlace = "City D"
    };

    players[4] = new Player
    {
        LastName = "Davis",
        DateOfBirth = new DateTime(2004, 5, 5),
        Club = "Club A",
        Position = "Defender",
        GamesPlayed = 55,
        BirthPlace = "City E"
    };

    PrintYoungDefenders(players);
}

void PrintYoungDefenders(Player[] players)
{
    foreach (Player player in players)
    {
        int age = DateTime.Now.Year - player.DateOfBirth.Year;
        if (age < 20 && player.Position == "Defender" && player.GamesPlayed > 40)
        {
            Console.WriteLine($"Last Name: {player.LastName}");
            Console.WriteLine($"Date of Birth: {player.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Club: {player.Club}");
            Console.WriteLine($"Position: {player.Position}");
            Console.WriteLine($"Games Played: {player.GamesPlayed}");
            Console.WriteLine($"Birth Place: {player.BirthPlace}");
            Console.WriteLine();
        }
    }
}
Main();
struct Player
{
    public string LastName;
    public DateTime DateOfBirth;
    public string Club;
    public string Position;
    public int GamesPlayed;
    public string BirthPlace;
}


    