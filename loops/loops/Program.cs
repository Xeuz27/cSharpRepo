// See https://aka.ms/new-console-template for more information



System.Random random = new System.Random();
int playersLives = 3;
int playerTotalCount = 0;
int dealerTotalCount = 0;
int num = 0;
var message = "";
string anotherCardControl = "";
string switchControl = "menu";

// Black jack minigame

    Console.WriteLine($"you have a total of: {playersLives} lives \n");
while (playersLives > 0)
{
    playerTotalCount = 0;
    dealerTotalCount = 0;
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Welcome to the casino");
            Console.WriteLine("Write '21' to play blackjack");
            switchControl = Console.ReadLine();
            break;

        case "21":

                Console.WriteLine("\ntake your first hand player");
            do
            {
                num = random.Next(1, 12);
                playerTotalCount = playerTotalCount + num;
                Console.WriteLine($"your Hand is: {num}");
                Console.WriteLine("do you want another Card? if yes write 'y'");
                anotherCardControl = Console.ReadLine();

            } while (anotherCardControl == "y" || anotherCardControl == "Y");

            dealerTotalCount = random.Next(14, 23);
            Console.WriteLine($"dealer has: {dealerTotalCount} \n");

            if (playerTotalCount > dealerTotalCount && playerTotalCount < 22)
            {
                message = "You won, congratulations! \n";
                switchControl = "menu";
                playersLives = playersLives + 1;

            }
            else if (playerTotalCount >= 22)
            {
                message = "You lost, try again \n";
                switchControl = "menu";
                playersLives = playersLives - 1;
            }
            else
            {
                message = "You lost, try again \n";
                switchControl = "menu";
                playersLives = playersLives - 1;

            }

            Console.WriteLine($"Player Total Count: {playerTotalCount}");
            Console.WriteLine($"Dealer Total Count: {dealerTotalCount}");
            Console.WriteLine(message);

            break;
        default:
            switchControl = "menu";
            Console.WriteLine("invalid option try again");
            // Code to execute if no case matches the expression
            break;
    }

}
Console.WriteLine($"you lost all your lives, restart to try again");