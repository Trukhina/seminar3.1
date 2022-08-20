/* Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]
*/

void RandArray()
{
    int[] arr = new int[3];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 36);
    }
Console.WriteLine($"[{String.Join(",", arr)}]");
} 
RandArray();
