// Не используя рекурсию, выведите первые N чисел Фибоначи.
// Первые два числа Фибоначи: 0 и 1.


void Fib(int num)
{
    int n_1 = 0;
    int n_2 = 1;
    
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{n_1} ");
        (n_1, n_2) = (n_2, n_1 + n_2);         
    }
    Console.WriteLine();    
}

Fib(5);
Fib(7);
