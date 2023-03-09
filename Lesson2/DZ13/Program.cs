/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number = Number(num);

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(number);
}

int Number(int chislo)
{
    int needchislo = chislo;
    while (needchislo > 999)
    {
        needchislo = needchislo / 10;
    }
    return needchislo % 10;
}
