/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Дан массив: ");
int[] num = new int[6];

GetArray(num, 100, 1000);
void GetArray(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(minValue, maxValue);
    }
}

ResArray(num);
void ResArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(String.Join(" ", array[i])); 
    }
    Console.WriteLine();
}

int number = NumberPositive(num);
int NumberPositive(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            number++;
        }
    }
    return number;
}

Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {number}");