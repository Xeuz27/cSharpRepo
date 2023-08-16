// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int playerTotalCount = 0;
int dealerTotalCount = 0;
string message = "";
//black jack minigame
if (playerTotalCount > dealerTotalCount)
{
    message = "you won, congratulations!";
}else if (playerTotalCount > 21)
{
    message = "you lost, try again";
}
else if (playerTotalCount <= dealerTotalCount)
{
    message = "you lost, try again";
}
else
{
    message = "invalid condition";
}