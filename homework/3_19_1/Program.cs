// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
bool Palindrome(string num)
{
    int i = 0;
    while (i < num.Length/2)
    {
        if (num[i] != num[num.Length - i - 1])
        {
            return false;
        }
        i ++;
    }
    return true;
}

Console.Write("Write a number N: ");
string n = Console.ReadLine();
if (Palindrome(n) == true)
{
    Console.WriteLine("The number is a palindrome");
}
else
{
    Console.WriteLine("The number is not a palindrome");
}