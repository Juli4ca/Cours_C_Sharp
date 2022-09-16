// 3: Напишите программу, которая будет создавать копию заданного массива(вещественные числа) 
//с помощью поэлементного копирования.


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}

double[] CopiMas(double[]arr)
{
    int size = arr.Length;
    double[] new_arr = new double[size];
    for (int i = 0; i < size; i++) new_arr[i] = arr[i];
    return (new_arr);
}

double[] arr_1 = MassNums(10);
Print(arr_1);
double[] new_arr_1 = CopiMas(arr_1);
Print(new_arr_1);