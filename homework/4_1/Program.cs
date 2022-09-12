// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
void exponent (int a, int b)
{
    int res = a;
    for (int i = 2; i <= b; i++)
    {
        res = res * a;
    }
    
    Console.WriteLine(res);

}

exponent(2, 4);

