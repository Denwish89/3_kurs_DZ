// Задача 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3, 6, 8); B (2, 1, -7) -> 15,84
// A (7, -5, 0); B (1, -1, 9) -> 11,53

// 1. Принять координаты двух точек.
// 2. Вывести расстояние между ними в 3D

Console.Write("Введите координату x точки A: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
int zCoordinate1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x точки B: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int zCoordinate2 = Convert.ToInt32(Console.ReadLine());

double coordinate = lenght(xCoordinate1, yCoordinate1, zCoordinate1, xCoordinate2, yCoordinate2, zCoordinate2);
Console.WriteLine(coordinate);

double lenght(int x1, int y1, int z1, int x2, int y2, int z2)
{

    double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    double dRound = Math.Round(d, 2, MidpointRounding.ToZero);//вызываем метод с округлением, первым параметром идет число, которое нужно округлить, вторым параметром до скольки знаков после запятой нужно округлить, третий параметр стратегия округления на подходе к ToZero

    return dRound;
}

