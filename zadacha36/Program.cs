﻿/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(4, 1, 10);
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите array[{i}] = ");
    array[i] = int.Parse(Console.ReadLine());
} 
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    {
        sum += array[i];
    }
}

Console.WriteLine($"Сумма нечетных элементов: {sum}");