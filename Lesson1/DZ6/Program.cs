/* Напишите программу, которая на вход
принимает число и выдает, является ли
число четным (делится ли оно на 2 без остатка)
4 -> да
-3 -> нет
7 -> нет */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int rezult = number % 2;

if (rezult == 0) Console.Write("Число является четным!");
else
Console.Write("Число не является четным!");