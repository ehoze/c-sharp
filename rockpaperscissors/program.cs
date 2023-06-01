using System;

    Random random = new Random();
    bool playAgain = true;
    String player;
    String computer;
    string answer;

    while (playAgain)
    {
        player = ""; computer = ""; answer = "";
        while (player != "papier" && player != "kamien" && player != "nozyce")
        {
            Console.Write("Wprowadz papier, kamien lub nozyce: ");
            player = Console.ReadLine(); player = player.ToLower();
        }
        int randomNum = random.Next(1, 4);
        switch (random.Next(1, 4))
        {
            case 1:
                computer = "papier";
                break;
            case 2:
                computer = "kamien";
                break;
            case 3:
                computer = "nozyce";
                break;
        }
        Console.WriteLine($"\nGracz wybral {player}");
        Console.WriteLine($"Komputer wybral {computer}");

        switch (player)
        {
            case "papier":
                if (computer == "papier")
                {
                    Console.WriteLine("Remis");
                }
                else if (computer == "kamien")
                {
                    Console.WriteLine("Wygrales!");
                }
                else
                {
                    Console.WriteLine("Przegrales");
                }
                break;
            case "kamien":
                if (computer == "papier")
                {
                    Console.WriteLine("Przegrales");
                }
                else if (computer == "kamien")
                {
                    Console.WriteLine("Remis");
                }
                else
                {
                    Console.WriteLine("Wygrales!");
                }
                break;
            case "nozyce":
                if (computer == "papier")
                {
                    Console.WriteLine("Wygrales!");
                }
                else if (computer == "kamien")
                {
                    Console.WriteLine("Przegrales");
                }
                else
                {
                    Console.WriteLine("Remis");
                }
                break;
        }
        Console.WriteLine();
        Console.WriteLine("Chcesz zagrac jeszcze raz (Y/N): ");
        answer = Console.ReadLine();
        playAgain = (answer.ToUpper() == "Y") ? true : false;

    }
    Console.WriteLine("\nDzięki za grę!");
}
