﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
string NumSec(int num) 
{
    if ((-1000 < num && num < -100) || (num < 1000 && 100))
       return $ "{num / 10 % 10}";
    return "Нет";
}
Console.Writeline(NumSec(int.Parse(Console.ReadLine())));
