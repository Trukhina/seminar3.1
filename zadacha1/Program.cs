Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
int min = numberB;

if(numberB > max) max = numberB;

 Console.WriteLine(max);
