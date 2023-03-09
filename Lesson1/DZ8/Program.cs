/* Напишите программу, которая на вход
принимает число (N), а на выходе показывает все четные
числа от 1 до N
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (number > 0)
{
    while (i <= number)
    {
    int result = i % 2;
        if (result == 0) Console.WriteLine(i);
    i++;
    }
}
else
{
Console.Write("Нужно ввести положительное целое число");
}