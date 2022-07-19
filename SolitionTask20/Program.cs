// Задача 20 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09


int Ax;//GlobalizationBle
int Ay; //всегда сверху
int Bx;
int By;// Объявить переменные т.к. они внутри метода ГЛОБАЛ епта
double Length;// 

void Points()// Считывает координаты А и В
{
    Console.WriteLine("Enter x for point A:");
    Ax = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter y for point A:");
    Ay = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter x for point B:");
    Bx = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter y for point B:");
    By = int.Parse(Console.ReadLine());
}

void LengthAB()// Метод - вычисление АБ
{
Length = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));// double!!!
}

Points();
LengthAB();

Console.WriteLine(Length);