//Задача 35 массив 123эл., сколько эл. в отрезке 10, 99

int[] FillingArray() //Задаем массив на 123
{
    int[] outArray = new int[123]; 
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 123)
    {
        outArray[i] = numberSintezator.Next(0, 123);
        i++;
    }
    return outArray;
}

void PrintArray(int[] array)// выводим на экран массив из 123 случ чисел
{
    int i = 0;
    while (i < array.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i]);//Допечатать последний элемент массива
}

int ColculateTask(int[] array, int totalSum)// Считаем сумму эл.в
{
    int sum = 0;
    int i = 0;// итератор
    while (i<123)
    {
        if (array[i] > 9 && array[i] <100)// принимает Буул переменную
        {
            sum = sum+array[i];
        }
        else
        {
            sum = sum+0;
        }
        i++;
    }
    return sum;
}

int [] bufferArray = FillingArray();
PrintArray(bufferArray);
Console.Write("Сумма = ");
int totalSum = 0;
Console.WriteLine(ColculateTask(bufferArray,totalSum));