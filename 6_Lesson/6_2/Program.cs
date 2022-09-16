// Напишите программу, которое будет преобразовывать десятичное число в двоичное.


string Binary(int num)
{
    string res = "";

    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}

Console.WriteLine(Binary(12)); // 1100
Console.WriteLine(Binary(4)); // 100
Console.WriteLine(Binary(45)); // 101101