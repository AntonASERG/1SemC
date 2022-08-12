// задача 45 копия массива поэлементарое копирование

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

object[] CopyArrayStandartTool(params object[] inputArray)//корневой тип object - любой тип (int string double)
{
    object[] bufferArray = new object[inputArray.Length];
    inputArray.CopyTo(bufferArray,0);
    return bufferArray;
}

int[] restArray = FillingArray();
PrintArray(restArray);

int[] outArray = CopyArrayStandartTool(())restArray);// согласовать типы!!!!!!
PrintArray(outArray);