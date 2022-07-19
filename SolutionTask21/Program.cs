// Задача 21 Напишите программу, которая принимает на вход
// координаты 3 точек и находит расстояние между
// ними в 3D пространстве.
// Например: A (3,6,5); B (2,1,7) -> 5,09.....


int Ax;//GlobalizationBle
int Ay; //всегда сверху
int Az;
int Bx;
int By;// Объявить переменные т.к. они внутри метода ГЛОБАЛ
int Bz;
double Length3d;// 

void Points()// Считывает координаты А и В
{
    Console.WriteLine("Enter x for point A:");
    Ax = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter y for point A:");
    Ay = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter z for point A:");
    Az = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter x for point B:");
    Bx = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter y for point B:");
    By = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter z for point B:");
    Bz = int.Parse(Console.ReadLine());
}

void LengthAB()// Метод - вычисление АБ
{
Length3d  = Math.Sqrt(Math.Pow((Ax-Bx),2)+ Math.Pow((Ay-By),2) + Math.Pow((Az-Bz),2));

}

Points();
LengthAB();

Console.WriteLine(Length3d);