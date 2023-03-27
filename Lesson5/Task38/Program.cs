// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 0, 100); //Вызываваем метод создающий массив
PrintArrayDouble(array); //Вызываваем метод вывода в консоль
double maxNum = Max(array);
double minNum = Min(array);
double maxMin = MaxMin(maxNum, minNum);
Console.Write($" -> {maxMin}");

double[] CreateArrayRndDouble(int size, int min, int max) // метод создающий массив
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;

}

void PrintArrayDouble(double[] arrayValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (i != arrayValue.Length - 1) Console.Write($"{arrayValue[i]}, ");
        else Console.Write($"{arrayValue[i]}");
    }
}

double Min(double[] arrMin)
{
    int size = arrMin.Length;
    double num = arrMin[0];

    for (int i = 1; i < size; i++)

    if (num < arrMin[i])
    {
        num = arrMin[i];
    }
    return num;
}

double Max(double[] arrMax)
{
    int size = arrMax.Length;
    double num = arrMax[0];

    for (int i = 1; i < size; i++)

    if (num > arrMax[i])
    {
        num = arrMax[i];
    }
        return num;
}

double MaxMin(double max, double min)
{
    double num = 0;
    num = max - min;
    return Math.Round(num, 1);
}