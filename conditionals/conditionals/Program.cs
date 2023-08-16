
Console.WriteLine("Hello, World!");

int playerTotalCount = 21;
int dealerTotalCount = 15;
var message = "";
string switchControl = "menu";

// Black jack minigame
switch (switchControl)
{
    case "menu":
        Console.WriteLine("Welcome to the casino");
        Console.WriteLine("Write '21' to play blackjack");
        switchControl = Console.ReadLine();
        break;

    case "21":

        if (playerTotalCount > dealerTotalCount && playerTotalCount < 22)
        {
            message = "You won, congratulations!";
        }
        else if (playerTotalCount >= 22)
        {
            message = "You lost, try again";
        }
        else
        {
            message = "You lost, try again";
        }

        Console.WriteLine($"Player Total Count: {playerTotalCount}");
        Console.WriteLine($"Dealer Total Count: {dealerTotalCount}");
        Console.WriteLine(message);

        break;
}

Console.ReadLine();
