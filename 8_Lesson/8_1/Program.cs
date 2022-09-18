// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это не возможно, программа должна вывести сообщение для пользователя.

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

string ReplaceRowColum(int[,]arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (row != column) 
        return "It is not possible to replace rows with columns";

    for (int i = 0; i < column; i++)
        for (int j = 0; j < i; j++)
        {
            (arr[i,j], arr[j, i]) = (arr[j, i], arr[i, j]);
        }
        return "It's possible to replace rows with columns";

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 6);
Print(arr_1);

ReplaceRowColum(arr_1);
Print(arr_1);

Console.WriteLine($"{ReplaceRowColum(arr_1)}");
Console.WriteLine();

// int[,] ReplaceRowColum(int[,]arr)
// {
//     int row = arr.GetLength(0);
//     int column = arr.GetLength(1);
//     int[,] new_arr = new int[row, column];

//     for (int i = 0; i < column; i++)
//         for (int j = 0; j < row; j++)
//             new_arr[i, j] = arr[j, i];
          
//     return new_arr;
// }

// Console.Write("Enter the number of rows: ");
// int row = int.Parse(Console.ReadLine());
// Console.Write("Enter the number of columns: ");
// int column = int.Parse(Console.ReadLine());

// int[,] arr_1 = MassNums(row, column, 1, 6);
// Print(arr_1);

// arr_1 = ReplaceRowColum(arr_1);
// Print(arr_1);