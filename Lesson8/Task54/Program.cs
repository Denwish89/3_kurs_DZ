// Задача 54. Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой сторки двумерного массива.

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
SelectionSort(array2d);
Console.WriteLine();
PrintMatrix(array2d);

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

void SelectionSort(int[,] arraySort)
{
    for (int i = 0; i < arraySort.GetLength(0); i++)
    {
        for (int j = 0; j < arraySort.GetLength(1); j++)
        {
            for (int min = 0; min < arraySort.GetLength(1) - 1; min++)
            {
                if (arraySort[i, min] < arraySort[i, min + 1])
                {
                    int temporary = arraySort[i, min + 1];
                    arraySort[i, min + 1] = arraySort[i, min];
                    arraySort[i, min] = temporary;
                }
            }
        }
    }
}

