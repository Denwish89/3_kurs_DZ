// Задача №27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// 1. Принять число
// 2. Вывести сумму цифр в числе

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр числа {number} -> {sumNumber}");

int SumNumber(int num)
{
    int ostNum = 0;
    int sumNum = 0;
    
    while (num != 0)
    {
        sumNum = sumNum + num % 10;
        num = num / 10;
    }
    sumNum = sumNum + num;
    return sumNum;
}
