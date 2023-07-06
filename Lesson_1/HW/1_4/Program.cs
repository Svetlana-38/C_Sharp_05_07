// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");

int n = int.Parse(Console.ReadLine()!);

int count = 2;
while (count <= n)
{
   Console.Write($"{count}  ");
   count+=2;
}