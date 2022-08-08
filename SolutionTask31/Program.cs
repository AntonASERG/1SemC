// Задача 32 массив [12] -9:9 сумма + и сумма -
int posetivSum = 0;
int negativeSum = 0;

int[] FillingArray() //метод возвращает массив заполненный от -9 до 9
{
    int[] outArray = new int[12]; // выделяем память под массив из 12 эл-в
    int i = 0;
    System.Random numberSintezator = new System.Random();

    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
        i++;
    }
    return outArray;
}

void ColculateTask(int[] outArray)// Метод принимает массив, который считаем
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            posetivSum += outArray[i];// П = П+число массива
        }
        else
        {
            negativeSum += outArray[i];
        }
    }
}

void PrintResult()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativeSum);
}

void PrintArray(int[] array)
{
    //Буфферная переменная
    int i = 0;
    while (i < array.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i]);//Допечатать последний элемент массива
}

void VariantNaive()
{
    int[] bufferArray = FillingArray();// Сама программа, состоит из методов
    PrintArray(bufferArray);// метод принимает новый массив Буфферарей
    ColculateTask(bufferArray);
    //ColculateTask(FillingArray()); - как вариант 2 двух строк выше
    PrintResult();

}

VariantNaive();