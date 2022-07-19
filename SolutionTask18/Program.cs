// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

//Задача 18

void printA(int number)// НИЧЕГО НЕ ВОЗВРАЩАЕТ на(перемен) не обращаю внимание
{
    if(number == 1) Console.WriteLine("Допустимо X>0 Y>0");
    if(number == 2) Console.WriteLine("Допустимо X<0 Y>0");
    if(number == 3) Console.WriteLine("Допустимо X<0 Y<0");
    if(number == 4) Console.WriteLine("Допустимо X>0 Y<0");
}

string? inputline = Console.ReadLine();

if(inputline != null)
{
    int inputnumber = int.Parse (inputline);
    printA(inputnumber);
}
