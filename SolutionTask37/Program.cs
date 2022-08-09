//Задача 37  произведение пар чисел в массиве в новом массиве

Console.Write("Задайте размер массива - ");
int len = int.Parse(Console.ReadLine());


int[] FillingArray() //Задать массив
{
    int[] outArray = new int[len];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < len)
    {
        outArray[i] = numberSintezator.Next(-1000, 1000);
        i++;
    }
    return outArray;
}

void PrintArray(int[] array)// печать массива
{
    int i = 0;
    while (i < array.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i]);//Допечатать последний элемент массива
}


int[] ColculateT(int[] array)// Считаем произведение пар элементов
{
    int[] resultArray = new int[array.Length / 2 + 1];// выделить ячейки под результаты перемножения
    int i = 0;// итератор

    while (i < resultArray.Length)
    {
        resultArray[i] = array[i] * array[array.Length - 1 - i];// в т ч Формула последнего элемента массива
        i++;
    }
    return resultArray;
}


int[] bufferArray = FillingArray();
PrintArray(bufferArray);
int[] totalArray = ColculateT(bufferArray);
PrintArray(totalArray);