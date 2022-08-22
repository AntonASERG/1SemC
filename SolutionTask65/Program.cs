// Задайте значени M  и N
// Программа - вывести все натуральные числа от  M до N

//===================================================================

// метод задать число
Console.Clear();// чистит консоль при запуске

int numberM = ReadData("Задайте число М - ");
int numberN = ReadData("Задайте число N - ");

if (numberM < numberN)
{ NaturalNumberNM(numberM, numberN); }
else
{ NaturalNumberNM(numberN, numberM); }


// метод от M до N рекурсия
// 3 6 NaturalNumberNM(m+1,n);// вызов метода. M+1 -увеличение
// 4 6
// 5 6

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine());// возвр число
}

void NaturalNumberNM(int m, int n)
{
    if (m - 1 == n) return; // остановка? m-1 - чтобы напечаталась последняя цифра
    Console.Write(m + " | ");
    NaturalNumberNM(m + 1, n);// вызов метода. M+1 -увеличение

}



