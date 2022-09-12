// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumDigits (int n)
{
    int res = 0;
    
    while (n > 0)
    {
        int dig = n % 10;
        res = res + dig;
        n = n / 10;
    }
    return res;
}


Console.WriteLine(sumDigits(9012));
