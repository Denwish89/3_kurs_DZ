// Задача 58. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] firstArray2d = CreateMatrixRndInt(4, 3, 1, 10);
int[,] secondArray2d = CreateMatrixRndInt(4, 3, 1, 10);
int[,] resultArray2d = ResultCreateMatrixRndInt(4, 3);

Console.WriteLine($"\nПервая матрица:");
PrintMatrix(firstArray2d);
Console.WriteLine();

Console.WriteLine($"\nВторая матрица:");
PrintMatrix(secondArray2d);
Console.WriteLine();
Console.WriteLine($"\nПроизведение первой и второй матриц:");
MultiplyArray2d(firstArray2d, secondArray2d, resultArray2d);
PrintMatrix(resultArray2d);

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

int[,] ResultCreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    return matrix;
}


void MultiplyArray2d(int[,] firstArray2d, int[,] secondArray2d, int[,] resultArray2d)
{
    for (int i = 0; i < firstArray2d.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray2d.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray2d.GetLength(1); k++)
            {
                sum += firstArray2d[i, k] * secondArray2d[k, j];
            }
            resultArray2d[i, j] = sum;
        }
    }
}