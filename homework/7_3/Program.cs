// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void ArithmeticMeanColumn(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double element_sum = 0;

    for (int i = 0; i < column; i++)
    {
        element_sum = 0;
        for (int j = 0; j < row; j++) element_sum += arr[j, i];
        Console.Write($"{Math.Round(element_sum / row, 2)}; ");
    }

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 6);
Print(arr_1);

ArithmeticMeanColumn(arr_1);