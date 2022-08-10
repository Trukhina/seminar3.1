/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/ 

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int a1 = num % 10;
int a3 = num / 100;

int result= (num - a3 * 100 - a1) / 10;

Console.WriteLine($"результат{result}");

