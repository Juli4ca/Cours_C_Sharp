﻿// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

void Checking (int a, int b)
{
    if (a % b == 0)
    Console.WriteLine($"{a} multiple {b}");
    else
    Console.WriteLine($"{a} not multiple {b}, remainder of the division {a % b}");
}
Checking (15,4);