﻿/* Напишите программу, которая на вход принимает
два числа и выдает, какое число большее,
а какое меньшее
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3 */

Console.WriteLine("Нужно ввести два числа!");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine("Число " + number1 + " больше числа " + number2);
if (number1 < number2) Console.WriteLine("Число " + number2 + " больше числа " + number1);