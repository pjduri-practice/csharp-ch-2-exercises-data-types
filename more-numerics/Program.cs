// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculate your gas mileage!");
Console.WriteLine("How many miles have you driven?");
double miles = double.Parse(Console.ReadLine());
Console.WriteLine("How many gallons of gas have you burned?");
double fuelSpent = double.Parse(Console.ReadLine());
double mpg = miles / fuelSpent;
Console.WriteLine("You are getting " +  mpg + " miles per gallon.");
