// See https://aka.ms/new-console-template for more information


using System.IO.Compression;

int num1;
int num2;

Console.Write("Input a number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 * num2;
Console.WriteLine(result);

Console.ReadKey();

