//Перевернуть массив

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

int[] InvertMass (int[] arr)
{
    int help = 0;
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)   
    {
        help = arr[i];
        arr[i] = arr[size - i - 1];
        arr[size - i - 1] = help;
    }
    
    return(arr);
}

int[] arr_1 = MassNums(4, 0, 11);
Print(arr_1);
int[] new_arr_1 = InvertMass(arr_1);
Print(new_arr_1);