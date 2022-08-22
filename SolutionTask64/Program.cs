// Задача 64. Задайте значение N
//  программа выдаст все натуральные числа от N до 1
//===================================================================

// метод задать число
int ReadData()
{
    Console.Write("i =   ");
    return int.Parse(Console.ReadLine());// возвр число
}

// METHOD программа выдаст все натуральные числа от N до 1
int NuturalNumberPrinter (int num)
{
    if (num == 1) return 1;// число  1 СТОПФАКТОР!
    else // на этом шаге цикл падает вниз и выдает с конца
    {
        num--;// num = num-1
        Console.Write(num + " "); //Вывод чисел
        NuturalNumberPrinter(num);//метод спускается вниз по стекам
    }
    return num;
}

int i = ReadData();
NuturalNumberPrinter(i+1);