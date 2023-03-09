/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
bool number = Number(num);

if (num > 7 || num < 1)
{
    Console.WriteLine("Номер введен некорректно, допустимое число от 1 до 7 включительно");
}
else
{
    Console.WriteLine(number ? "Нет" : "Да");
}

bool Number(int chislo)
{
    return chislo < 6;
}