// Задача 66. Задайте значения M и N. Напишите прорамму, которая найдет сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int number1 = UserInput("Введите первое число: ");
int number2 = UserInput("Введите второе число: ");
Sum(number1, number2);

void Sum(int numberM, int numberN)
{
    Console.Write(naturalNumberInterval(numberM - 1, numberN));
}

int naturalNumberInterval(int numberM, int numberN)
{
    int result = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        result = numberM + naturalNumberInterval(numberM, numberN);
        return result;
    }
}

int UserInput(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
