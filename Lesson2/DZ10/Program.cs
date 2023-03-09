/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите натуральное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number = Number(num);
Console.WriteLine(number);

int Number(int chislo)
{
    return (chislo % 100) / 10;
}
