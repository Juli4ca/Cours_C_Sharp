// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Write a number A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Write a number B: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Write a number С: ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.Write("maximum number  - ");
        Console.WriteLine(a);
    }
    else
    {
        Console.Write("maximum number  - ");
        Console.WriteLine(c);
    }
}
else
{
    if (b > c)
    {
        Console.Write("maximum number  - ");
        Console.WriteLine(b);
    }
    else
    {
        Console.Write("maximum number  - ");
        Console.WriteLine(c);
    }
}
