// Задача 32 массив  -поменять местами +и 1

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

int[] ColculateTask(int[] array)// Метод принимает массив, который считаем
{
    int[] output = new int[12];
    int i = 0;
    while (i < 12)// Цикл проходит по всем элементам массива
    {
        output[i]=array[i]*-1;
    }
    return output;
}

int InventArrayTilda(int[] array)// Метод инверсии массива
{
    int i = 0;//буфферная переменная
    while (i < array.Length)
    {
        array[i]=(~array[i])+1;// инверсия ~
        i++;
    }
    return array;
}

int[] bufferArray = FillingArray();// Сама программа, состоит из методов
PrintArray(bufferArray);// метод принимает новый массив Буфферарей
int[] reasultArrray = ColculateTask(bufferArray);
PrintArray(reasultArrray);
reasultArrray = InventArrayTilda(bufferArray);
PrintArray(reasultArrray);

