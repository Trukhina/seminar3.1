/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int a1 = num % 10;
int a5 = num / 10000;
int a2 = num % 100 / 10;
int a4 = num / 1000 % 10;
// Console.WriteLine(a4);    - Проверка а1, а2, а5, а4

if (a1 == a5 && a2 == a4)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

