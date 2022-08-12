//Задача 39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Write("Задайте размер массива - ");
int len = int.Parse(Console.ReadLine());


int[] FillingArray(int len) //возвращает массив заполненный случайными числами
{
    int[] outArray = new int[len];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < len)
    {
        outArray[i] = numberSintezator.Next(0, 100);
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


int[] ReversNewArray(int[] array)// метод перевернуть массив 1
{
    int length = array.Length;// переменная = длине входного массива
    int[] newArray = new int [length];// новый масссив = по длине входному

    for (int i = 0; i < length; i++)// инкримент
    {
        newArray[length-1-i] = array[i];// формула реверса
    }
    return newArray;// вовращаем реверс
}

int[] ReversSwapArray(int[] array)// метод перевернуть массив 1
{
    int length = array.Length;// переменная = длине входного массива
    int buf;//буфферная переменная

    for (int i = 0; i < length/2; i++)// инкримент
    {
        buf = array[i];// формула реверса swap
        array[i] = array[length - 1- i];
        array[length - 1 - i]= buf;
    }
    return array;// вовращаем реверс
}

int[] bufferArray = FillingArray(len);// в скобках можно задать размер, не удобно
int[] totalArray = ReversNewArray(bufferArray);

PrintArray(bufferArray);
PrintArray(totalArray);
PrintArray (ReversSwapArray(bufferArray));
PrintArray(bufferArray);