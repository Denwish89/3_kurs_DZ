// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 

// 1. Принять число N
// 2. Выдать таблицу кубов чисел от 1 до N

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    Console.WriteLine("Введено некорректное число");
}
else
{
    TableCube(N);

    void TableCube(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i}, {i * i * i}");
        }
    }
}

