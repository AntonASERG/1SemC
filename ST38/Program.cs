// Задача 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Задайте размер массива - ");
int len = int.Parse(Console.ReadLine());

int[] FillingArray() //Задать массив 
{
    int[] outArray = new int[len];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < len)
    {
        outArray[i] = numberSintezator.Next(1, 20);//Диапазон 3х значных чисел
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

int MaxWithoutMin(int[] array)// Сумма нечетных индексов
{
    int b = 0;// разница макс и мин
    int i = 0;// итератор
    int max = int.MinValue;// чтоб меньше некуда - минимальное значение
    int min = int.MaxValue;// максимальное значение
    while (i < array.Length)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        i++;
    }
    b = b + max - min;
    return b;
}


static void Swap(int[] array, int i, int j)// метод Swap() меняющий два элемента массива местами
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

static void InsertionSort(int[] inArray)//метод, реализующий метод сортировки массива вставками.
{
    int x;
    int j;
    for (int i = 1; i < inArray.Length; i++)
    {
        x = inArray[i];
        j = i;
        while (j > 0 && inArray[j - 1] > x)
        {
            Swap(inArray, j, j - 1);
            j -= 1;
        }
        inArray[j] = x;
    }
}






int[] bufferArray = FillingArray();
PrintArray(bufferArray);
 int total = MaxWithoutMin(bufferArray);
Console.Write("Разница = ");
Console.WriteLine(total);

InsertionSort(bufferArray);// реализация метода вставки
Console.WriteLine("\r\nОтсортированный массив:");
foreach (int value in bufferArray)
{
    Console.Write($"{value} ");
}