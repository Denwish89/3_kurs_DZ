// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(4, 1, 100); //Вызываваем метод создающий массив
PrintArray(array); //Вызываваем метод вывода в консоль
int nechetn = Nechetn(array);
Console.Write($" -> {nechetn}"); //Вызываваем метод вывода в консоль

int[] CreateArrayRndInt(int size, int min, int max) // метод создающий массив
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;

}

void PrintArray(int[] arrayValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (i != arrayValue.Length - 1) Console.Write($"{arrayValue[i]}, ");
        else Console.Write($"{arrayValue[i]}");
    }
}

int Nechetn(int[] arr)
{
    int num = 0; 
    int size = arr.Length;
    for (int i = 0; i < size; i++)

    if (i % 2 != 0)
    {
        num = arr[i] + num;
    }
    return num;
}

