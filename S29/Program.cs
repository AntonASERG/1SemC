//Задача 29 массив из 8 элементов *
System.Random numberSint = new Random(); // Обращение к системному рандомайзеру
Console.WriteLine("Введите длину массива:");
int len = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начало диапазона:");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец диапазона:");
int end = int.Parse(Console.ReadLine());

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while (i<len-1)
    {
        Console.Write(numberSint.Next(start,end+1)+",");// Диапазон от 0 до 1 вкл
        i++;
    }
    Console.Write(numberSint.Next(start,end+1));
    Console.Write("]");
}

VariantNaive();