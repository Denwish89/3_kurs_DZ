// Задача 43. Напишите программу, которая найдет точку
// пересечения двух прямых, заданных уровнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 1. Получить значения b1, k1, b2 и k2
// 2. Вывести точку пересечения двух прямых, заданных уровнениями y = k1 * x + b1,
// y = k2 * x + b2;

Console.WriteLine("введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());

int x = (-b2 + b1)/(-k1 + k2);
int y = k2 * x + b2;

Console.WriteLine($"Координаты точки пересечения X: {x}, Y: {y}");