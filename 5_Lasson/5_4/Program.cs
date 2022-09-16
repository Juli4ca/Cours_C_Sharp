// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] NewMass (int[] arr)
{
    int i = 0;
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] arrey = new int[flex_size];
    
    while (i < size / 2)
    {
        arrey[i] = arr[i] * arr[size - i - 1];
        i++;
    }
    if (arrey[flex_size - 1] == 0)
        arrey[flex_size - 1] = arr[flex_size - 1];

    return(arrey);
}

int[] arr_1 = MassNums(4, 0, 11);
Print(arr_1);
int[] new_arr_1 = NewMass(arr_1);
Print(new_arr_1);