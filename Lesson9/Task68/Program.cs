// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n/

// m = 3, n = 2 -> A(m, n) = 29

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Akkerman(m,n);

void Akkerman(int m, int n)
{
    Console.Write(Akn(m, n)); 
}

int Akn(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akn(m - 1, 1);
    }
    else
    {
        return (Akn(m - 1, Akn(m, n - 1)));
    }
}
