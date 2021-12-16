
string secretWord = "giraffe";
string guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outOfGusses = false;

while (guess != secretWord && !outOfGusses)
{
    if (guessCount < guessLimit)
    {
        Console.WriteLine("Enter guess: ");
        guess = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outOfGusses = true;
    }

}
if (outOfGusses)
{
    Console.Write("You Lose!");
}
else
{
    Console.WriteLine("You win");
}


Console.ReadLine();