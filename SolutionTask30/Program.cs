//Задача 30 массив из 8 цифр 1 и 0 [1,1,1,0,1,1,0,0]
System.Random numberSint = new Random(); // Обращение к системному рандомайзеру

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while (i<8-1)
    {
        Console.Write(numberSint.Next(0,2)+",");// Диапазон от 0 до 1 вкл
        i++;
    }
    Console.Write(numberSint.Next(0,2));
    Console.Write("]");
}

VariantNaive();