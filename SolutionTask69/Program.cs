// Задача 69 Принимает 2 числа А В и возводит А в  целую Степень В рекурсией

//===================================================================

Console.Clear();// чистит консоль при запуске

// метод задать число
Console.Clear();// чистит консоль при запуске

int numA = ReadData("Задайте число A - ");
int numB = ReadData("Задайте число B - ");// I'm tired of being what you want me to be :)


DateTime d = DateTime.Now;
int res1 = PowRecurs(numA, numB);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
int res2 = PowAndrey(numA, numB);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
double res3 = Math.Pow(numA, numB);
Console.WriteLine(DateTime.Now - d);

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(res3);

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine());// возвр число
}
// метод 1 почти цикл
int PowRecurs(int a, int b)
{
    if (b == 1) return a;// 1 степень плюс СТОП
    return a * PowRecurs(a, --b); // переумеожение числа а на а - количество от B до 1
}

// метод Андрея
//2*2*2*2*2*2*2*2
//      16*16
//  4*4      4*4
//2*2 2*2  2*2 2*2

int PowAndrey(int a, int b)
{
    if (b == 2)
    {
        return a*a;
    }
    if(b == 1)
    {
        return a;
    }
    if(b%2 == 0)
    {
        return PowAndrey(a,b/2)*PowAndrey(a,b/2);//половинки
    }
    else
    {
        return PowAndrey(a,b/2)*PowAndrey(a,b/2+1);// половинки если нечетная В
    }
}