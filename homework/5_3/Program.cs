// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums (int size, int from, int to)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void DifferenceMaxMin (double[] arr)
{
    int i = 0;
    double min = arr[i];
    
    double max = arr[i];
    
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            
            min = arr[i];
        }
        if (arr[i] > max)
        {
            
            max = arr[i];
        }
    }
    double dif = max - min;
    Console.WriteLine($"The difference between the maximum and minimum array elements - {dif}");
}

double[] arr_1 = MassNums(10, 0, 101);
Print(arr_1);
DifferenceMaxMin(arr_1);