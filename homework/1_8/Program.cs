// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Write a number: ");
int number = int.Parse(Console.ReadLine());
int i = 2;

while (i <= number)
{
    if (i != number && number % 2 == 0)
    {
        Console.Write(i);
        Console.Write(", ");
        i += 2;
    }
    else if (i == number && number % 2 == 0)
    {
        Console.Write(i);
        i += 2;
    }
    else if (number % 2 != 0 && i == number - 1)
    {
        Console.Write(i);
        i += 2;
    }
    else
    {
        Console.Write(i);
        Console.Write(", ");
        i += 2;
    }
 
}