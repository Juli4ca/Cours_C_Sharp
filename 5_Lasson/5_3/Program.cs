// Задайте одномерный массив из 123 случайных чисел. Найдите колличество элементов массива,
//значения которых лежат в отрезке [10,99].
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

void CheckNums (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            count += 1;                           
           
        }
          
    }
    Console.WriteLine($"The number of elements in the array, the value of which lies in a given segment {count}");

}
int[] arr_1 = MassNums(123, -100, 100);
Print(arr_1);
CheckNums(arr_1);