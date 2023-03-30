// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Укажите размеры массива по x: ");
int xRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите размеры массива по y: ");
int yColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите x позицию элемента: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите y позицию элемента: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

if (xCoordinate > xRows || yCoordinate > yColumns)
{
    Console.WriteLine($"{xCoordinate}, {yCoordinate} -> такого элемента в массиве нет");
}
else
{
    int xCoordinateRows = xCoordinate - 1;
    int yCoordinateColumns = yCoordinate - 1;

    int number = Number(xRows, yColumns, 1, 10, xCoordinateRows, yCoordinateColumns);
    Console.WriteLine($"{xCoordinate}, {yCoordinate} -> {number}");
}

int Number(int rows, int columns, int min, int max, int x, int y)
{
    int[,] matrix = new int[rows, columns];
    int num = 0;

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return num = matrix[x, y];
}






