// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopiMas(int[]arr)
{
    int size = arr.Length;
    int[] new_arr = new int[size];
    for (int i = 0; i < size; i++) new_arr[i] = arr[i];
    return (new_arr);
}

int[]arr_1 = MassNums(10, 0, 101);
Print(arr_1);
int[] arr_copi = CopiMas(arr_1);
Print(arr_copi);
