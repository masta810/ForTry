
// calling static method doen't require instance of class
Car.GetCarSize();


// normal methods require instance of class
var car = new Car();
car.Notify();

Console.WriteLine("Write your height: ");

var height = Console.ReadLine();

// string interpolation !! use interpolation !!
Console.WriteLine($"Your height is: {height}");

// string chaining
Console.WriteLine("Your height is: " + height);




