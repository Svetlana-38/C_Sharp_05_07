// 0. Напишите программу, которая на вход принимает число и
// выдаёт его квадрат (число умноженное на само себя).


Console.WriteLine("Write a number: ");
string num__str = Console.ReadLine()!;

int num = int.Parse(num__str);

//int num = int.Parse(Console.ReadLine());

Console.WriteLine(num*num);
