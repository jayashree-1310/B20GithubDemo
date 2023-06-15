// See https://aka.ms/new-console-template for more information

using FirstDemo;

Console.WriteLine("Hello Everyone");

Console.WriteLine("Welcome to Calculator");

Console.WriteLine("Please Enter First Number");
int a =int.Parse(Console.ReadLine());

Console.WriteLine("Please Enter Second Number");
int b= int.Parse(Console.ReadLine());   

Calculator c1= new Calculator();
c1.Add(a,b);

Console.ReadLine();
