﻿// Задача №29. Напишите программу, которая задает массив из 8 элементов, 
//заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Random rand = new Random();

    Array(array);
    WriteArray(array);
    Console.Write("-> [");
    WriteArray(array);
    Console.Write("]");

void Array(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(10, 100);
    }
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
                Console.Write(arr[i] + " ");

    }
}