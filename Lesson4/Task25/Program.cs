// Задача №25. Напишите цикл, который принимает на вход числа (A и B) 
//и возводит число (A) в натуральную степень (B)
// 3, 5 -> 243 (3 в 5 степени)
// 2, 4 -> 16

// 1. Прниять на вход 2 числа А и B
// 2. Возвести число А в натуральную степень B

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int number = Number(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} -> {number}");

int Number(int numA, int numB)
{
    for (int i = 1; i <= numB; i++)
    {
        numA *= i;
    }
    return numA;
}