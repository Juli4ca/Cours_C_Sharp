// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumDigits (string n)
{
    int res = int.Parse(n);
    
    for (int i = 1; i < n.Length; i++)
    {
        res = res + (res % 10);
    }
    return res;
}


Console.WriteLine(sumDigits("452"));
