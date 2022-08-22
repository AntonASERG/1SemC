// Задача 67 принимает число и выдает сумму его цифр

//===================================================================


Console.Clear();// чистит консоль при запуске

int number = ReadData("Задайте число  - ");
Console.WriteLine("Сумма цифр  = " + SumOfDigitsR(number));

// метод задать число
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine());// возвр число
}

//рекурентный метод суммы цифр
//12345 
//  - out 5 
//2 1234 out 4
// .........
// 7 0 out 0.....

int SumOfDigitsR(int num)
{
    if (num > 0)// точчка остановки
    {
        return num % 10 + SumOfDigitsR(num / 10); //%10 + рекурсия (числа/10)
    }
    else
    {
        return 0;//выдает точку остановки
    }
}



