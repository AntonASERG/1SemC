// Задача 66 Задайте значени M  и N
// Программа - вывести сумму нат чисел  M до N

//===================================================================

// метод задать число
Console.Clear();// чистит консоль при запуске

int numberM = ReadData("Задайте число М - ");
int numberN = ReadData("Задайте число N - ");
int sum = 0;

if (numberM < numberN)
{ SumNaturalNumberNM(numberM, numberN); }
else
{ SumNaturalNumberNM(numberN, numberM); }

Console.WriteLine("Сумма = " + sum);


int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine());// возвр число
}

// метод  сумма от M до N рекурсия (+ подсчет глобальной переменной SUM)
void SumNaturalNumberNM(int m, int n)
{
    if (m - 1 == n) return; // остановка? m-1 - чтобы напечаталась последняя цифра
    Console.Write(m + " | ");
    sum = sum+m;
    SumNaturalNumberNM(m + 1, n);// вызов метода. M+1 -увеличение
    
}



