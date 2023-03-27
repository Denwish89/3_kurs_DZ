// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateArrayRndInt(4, 100, 1000); //Вызываваем метод создающий массив
PrintArray(array); //Вызываваем метод вывода в консоль
int chetn = Chetn(array);
Console.Write($" -> {chetn}"); //Вызываваем метод вывода в консоль

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

int Chetn(int[] arr)
{
    int num = 0; 
    int size = arr.Length;
    for (int i = 0; i < size; i++)

    if (arr[i] % 2 == 0)
    {
        num++;
    }
    return num;
}

