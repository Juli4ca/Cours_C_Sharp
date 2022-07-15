//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

void SquareNumbers (int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i += 1;
    }
}
SquareNumbers(5);

