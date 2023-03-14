// Задача 19. Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом (текст, который читается и в одну сторону и в другую).
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите натурально пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool number = Number(num);

Console.WriteLine(num < 10000 || num > 99999 ? "Введено не корректное число!" : number ? "Да" : "Нет");

bool Number(int Num)
{
    int leftNum = Num / 1000;
    int rightNumLast1 = (Num % 100) / 10;
    int rightNumLast2 = Num % 10;
    int rightNumLast = rightNumLast2 * 10 + rightNumLast1;
    return leftNum == rightNumLast;
}
