// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Write a number A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Write a number B: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write("maximum number  - ");
    Console.WriteLine(a);
}
if (a < b)
{
    Console.Write("maximum number  - ");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("A = B");
}