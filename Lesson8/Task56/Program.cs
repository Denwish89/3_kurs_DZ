// Задача 56. Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);
int sum = SumRows(array2d, 0);
int minSum = 1;
int minSumRow = MinSumRow(array2d);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементовв строке: {minSum}");

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }

}

int SumRows(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int MinSumRow(int[,] array2d)
{
    for (int i = 1; i < array2d.GetLength(0); i++)
    {
        if (sum > SumRows(array2d, i))
        {
            sum = SumRows(array2d, i);
            minSum = i + 1;
        }
    }
    return minSum;
}
