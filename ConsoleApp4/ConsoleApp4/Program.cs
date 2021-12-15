Console.WriteLine("Better calculator");

Console.WriteLine("Enter a Number: ");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter Operator: ");
string op = Console.ReadLine();

Console.WriteLine("Enter a number: ");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Result:");

if (op == "+")
{
    Console.WriteLine(num1 + num2);
}
else if (op == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (op == "*")
{
    Console.WriteLine(num1 * num2);
}
else if (op == "/")
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("Invalid Operator");
}


Console.ReadLine();
