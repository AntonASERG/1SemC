// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых
//==============================================================================

int k1 = 0;
int k2 = 0;
int b1 = 0;
int b2 = 0;
int b3 = 0;
int k3 = 0;
double x1 = 0;
double y1 = 0;
double x2 = 0;
double y2 = 0;
double x3 = 0;
double y3 = 0;

Read();
Conculate();
Print();
Koord();

void Read()
{
Console.Write("Введите K1 ");
k1 = int.Parse(Console.ReadLine());
Console.Write("Введите K2 ");
k2 = int.Parse(Console.ReadLine());
Console.Write("Введите K3 ");
k3 = int.Parse(Console.ReadLine());
Console.Write("Введите b1 ");
b1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2 ");
b2 = int.Parse(Console.ReadLine());
Console.Write("Введите b3 ");
b3 = int.Parse(Console.ReadLine());

}

void Conculate()
{
x1 = (b2-b1)/(k1-k2);
y1 = k1*((b2-b1)/(k1-k2)) + b2;
x2 = (b2-b3)/(k3-k2);
y2 = k3*((b2-b3)/(k3-k2)) + b2;
x3 = (b3-b1)/(k1-k3);
y3 = k1*((b3-b1)/(k1-k3)) + b3;
}

void Print()
{
Console.WriteLine("x1:  " + x1 + " , y1:  " + y1);
Console.WriteLine("x2:  " + x2 + " , y2:  " + y2);
Console.WriteLine("x3:  " + x3 + " , y3:  " + y3);
}

// void Lensides()
// { 
//     double len12 =  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
//     double len13 =  Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)); 
//     double len23 =  Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)); 
// }

void Koord()
{
double s = ((x1-x3)*(y2-y3)-(x2-x3)*(y1-y3))/2;
    if (s > 0)
    {
        s = s;
    }
    else
    {
        s = s * -1;
    }
Console.WriteLine("Площадь треугольника =  " + s);
}




