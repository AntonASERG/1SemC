﻿string? A = Console.ReadLine();//Задача 2
string? B = Console.ReadLine();
if(A != null && B != null)
{
    int numberA = int.Parse (A);
    int numberB = int.Parse (B);
    if(numberA >= numberB)
    {
        Console.WriteLine(numberA);
    }
    else
    {
        Console.WriteLine(numberB);
    }
}