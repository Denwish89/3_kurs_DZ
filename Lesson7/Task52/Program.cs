// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:

// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4


// Console.WriteLine("введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
FillArrayRandomNumbers(array2d);

void FillArrayRandomNumbers(int[,] array)
{
for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sumColumns = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sumColumns = (sumColumns + array2d[i, j]);
    }
    sumColumns = Math.Round(sumColumns / array2d.GetLength(0), 1);

    Console.Write(sumColumns + "; ");
}
}
Console.WriteLine();
PrintArray(array2d);

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
