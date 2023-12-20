// See https://aka.ms/new-console-template for more information

using TestDrivenDesignIntro;

Console.WriteLine("Hello, to my calculator!");

Console.WriteLine("Please input the first number");
var operator1 = Console.ReadLine();
Console.WriteLine("Please input the second number");
var operator2 = Console.ReadLine();

Console.WriteLine("Your result is:");
var calculator = new AritmeticCalculator();
var result = calculator.AddNumbers(
  Int32.Parse(operator1), 
  Int32.Parse(operator2));

Console.WriteLine(result);