// 1. Напишите программу, которая принимает
// на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

Console.Write("Write a three-digit number N: ");
int n = int.Parse(Console.ReadLine());

if (n > 999 ^ n < 100)
{
    Console.Write("Invalid value N");
}
else
{
    Console.WriteLine(n % 10);
}