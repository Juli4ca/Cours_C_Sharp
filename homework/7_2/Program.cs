// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)        
            Console.Write($" {arr[i, j]} ");        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)    
        for (int j = 0; j < column; j++)        
            arr[i, j] = new Random().Next(from, to);          
    return arr;
}

string Element_Name(int[,] arr, int rou_e, int column_e)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
        
    for (int i = 0; i < row; i++)    
        for (int j = 0; j < column; j++)        
            if (i == rou_e && j == column_e) return $"Element name: {arr[i,j]}";

    return "No";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Enter the item position: ");
int rou_e_1 = int.Parse(Console.ReadLine());
int column_e_1 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

Console.Write($"{Element_Name(arr_1, rou_e_1, column_e_1)}"); 
