// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Randome01Array (int num)
{
    int [] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next();
        Console.Write($"{array[i]} ");
    }
}

Randome01Array(8);