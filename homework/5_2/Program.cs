// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums (int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int SumNumbers (int[]arr)
{
    int sum_n = arr[0];
    for (int i = 2; i < arr.Length; i+=2)
    {
        sum_n += arr[i];
    }
    Console.WriteLine(sum_n);
    return(sum_n);
}

int[] arr_1 = MassNums(10, 0, 11);
Print(arr_1);
int sum_n_1 = SumNumbers(arr_1);
