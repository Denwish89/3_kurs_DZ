// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь

// 0, 7, 8, -2 -> 2
//-1, -7, 567, 89, 223 -> 3

// 1. Получить числа M
// 2. Вывести сколько чисел больше 0 ввел польщователь

Console.Write("Введите необходимое количество элементов: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[numbers];

Numbers(numbers);
Console.WriteLine($"Чисел больше нуля: {Kolichestvo(Array)}");

void Numbers(int numbers)
{
    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Kolichestvo(int[] Array)
{
    int i = 0;
    int result = 0;
    while (i < Array.Length)
    {
        if (Array[i] > 0)
            result += 1;
        i = i + 1;
    }
    return result;
}