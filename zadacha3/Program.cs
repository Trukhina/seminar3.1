Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

int numberB = numberA % 2;

bool result = numberB == 0;

if(result)
{
    Console.WriteLine("четное число");
}
   
else
{
    Console.WriteLine("нечетное число");
}
