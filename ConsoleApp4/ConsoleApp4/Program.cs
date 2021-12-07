
bool isMale = true;
bool isTall = false;

if (isMale && isTall)
{
    Console.WriteLine("You are tall male");
}
else if (isMale && !isTall)
{
    Console.WriteLine("You are short male");
}
else if (!isMale && isTall)
{
    Console.WriteLine("You are not male but you are tall");
}
else
{
    Console.WriteLine("You are not male and not tall");
}

Console.ReadLine();