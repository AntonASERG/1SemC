// Задача 63. Задайте значение N
//  программа выдаст все натуральные числа от 1 до N
//===================================================================

// метод задать число
int ReadData()
{
    Console.Write("i =   ");
    return int.Parse(Console.ReadLine());// возвр число
}
// стек
// 1 4-3 - не печатает out
// 2 3- 2  out 2 вернет
// 3 - 2 out 1


int NuturalNumberPrinter (int num)
{
    if (num == 2) return 1;// 2 крайнее число перед 1 СТОПФАКТОР!
    else // на этом шаге цикл падает вниз и выдает с конца
    {
        num--;// num = num-1
        Console.WriteLine(num);
        Console.Write(NuturalNumberPrinter(num)+" ");// снова метод
    }
    return num;
}

int i = ReadData();
NuturalNumberPrinter(i+2);

