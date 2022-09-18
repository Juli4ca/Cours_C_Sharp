// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

int RowSumMin (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int element_sum = 0;
    for (int i = 0; i < column; i++)
        element_sum += arr[0, i];

    int element_sum_min = element_sum;

    for (int i = 0; i < column; i++)
    {
        if (element_sum_min > element_sum)
        {
            element_sum_min = element_sum;
        }
                
        for (int j = 1; j < row; j++) element_sum += arr[j, i];      
    }

    return element_sum_min;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, -5, 10);
Print(arr_1);

int min_num = RowSumMin(arr_1);
Console.WriteLine(min_num);