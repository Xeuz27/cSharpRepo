// See https://aka.ms/new-console-template for more information

using System;

// Initialize a random number generator
System.Random random = new System.Random();

// Initialize variables
int playerLives;
int playersbet;
int playerTotalCount = 0;
int dealerTotalCount = 0;
int num = 0;
var message = "";
string anotherCardControl = "";
string switchControl = "menu";
int platziCoins = 0;
string keepPlayingControl;
string keepPlayingControlLowerCase;

// Welcome message
Console.WriteLine("-----Welcome to the P L A T Z I N O----- \n");

// Main game loop
do
{
    // Get the number of lives the player wishes to buy
    Console.WriteLine("how many lives do you wish to buy?");
    playerLives = Convert.ToInt32(Console.ReadLine());

    // Start the game as long as the player has lives left
    while (playerLives > 0)
    {
        playerTotalCount = 0;
        dealerTotalCount = 0;

        // Main game logic based on a menu system
        switch (switchControl)
        {
            case "menu":
                // Menu option to play blackjack
                Console.WriteLine("-----Write '21' to play blackjack-----");
                switchControl = Console.ReadLine();
                break;
            case "21":
                // Get the player's bet
                Console.WriteLine("how many lives do you wish to bet?");
                do
                {
                    playersbet = Convert.ToInt32(Console.ReadLine());
                    if (playersbet > playerLives)
                    {
                        Console.WriteLine($"you don't have that many lives, please insert a number lower than {playerLives}");
                    }
                } while (playersbet > playerLives);

                // Player's turn to draw cards
                Console.WriteLine("-----Take your first Card player----- \n");
                do
                {
                    num = random.Next(1, 12);
                    playerTotalCount += num;
                    Console.WriteLine($"\n-----Your Card is: {num}-----");
                    Console.WriteLine($"-----You have {playerTotalCount}-----");

                    // Ask if the player wants another card
                    if (playerTotalCount < 21)
                    {
                        Console.WriteLine("do you want another Card? if yes write 'y'");
                        anotherCardControl = Console.ReadLine();
                    }
                    else
                    {
                        anotherCardControl = "no";
                    }
                } while (anotherCardControl == "y" || anotherCardControl == "Y");

                // Simulate the dealer's turn
                dealerTotalCount = random.Next(14, 23);

                // Determine the outcome of the game
                if (playerTotalCount > dealerTotalCount && playerTotalCount < 22 || dealerTotalCount > 21)
                {
                    message = "You won, congratulations! \n";
                    switchControl = "menu";
                    playerLives += playersbet;
                }
                else if (playerTotalCount >= 22)
                {
                    message = "You lost, try again \n";
                    switchControl = "menu";
                    playerLives -= playersbet;
                }
                else
                {
                    message = "You lost, try again \n";
                    switchControl = "menu";
                    playerLives -= playersbet;
                }

                // Display game results
                Console.WriteLine($"Player Total Count: {playerTotalCount}");
                Console.WriteLine($"Dealer Total Count: {dealerTotalCount}");
                Console.WriteLine(message);

                break;
            default:
                // Invalid menu option
                switchControl = "menu";
                Console.WriteLine("invalid option try again");
                break;
        }
        Console.WriteLine($"\n----- You have a total of: {playerLives} lives-----");
    }

    // Ask if the player wants to play again
    Console.WriteLine($"you lost all your lives, wanna try again? If yes write 'y'");
    keepPlayingControl = Console.ReadLine();
    keepPlayingControlLowerCase = keepPlayingControl.ToLower();

} while (keepPlayingControlLowerCase == "y");
