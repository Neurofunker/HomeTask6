﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Number[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] arr = CreateArray(M);
Console.WriteLine(arr);
int SearchPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int searchPositive = SearchPositive(arr);
Console.WriteLine($" Чисел больше = {searchPositive}");
