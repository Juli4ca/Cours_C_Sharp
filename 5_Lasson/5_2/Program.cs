// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве

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

void CheckNum (int num, int[] arr)
{
    string res = " ";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != num)
        {
            res = "not in the array";                           
           
        }
        else
        {
            res = "is in the array";         
            
        }
              
    }
    Console.WriteLine($"{num} {res}");

}
int[] arr_1 = MassNums(12, -1, 6);
Print(arr_1);
CheckNum(5, arr_1);