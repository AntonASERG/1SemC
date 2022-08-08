//Задача 33 усть ли число в массиве

int[] FillingArray() //метод задать массив
{
    int[] outArray = new int[12]; 
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
{// метод распечатывания массива
    //Буфферная переменная
    int i = 0;
    while (i < array.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i]);//Допечатать последний элемент массива
}

bool ColculateTask(int[] array, int searchNumber)// Да или нет
{
    bool resultSearch = false;// по умолчанию
    int i = 0;// итератор
    while (i<12)
    {
        if (array[i] == searchNumber)// принимает Буул переменную
        {
            resultSearch = true;
            break;// остановит цикл если нужно 1 значение
        }
        else
        {
            resultSearch = false;
        }
        i++;
    }
    return resultSearch;
}

int [] bufferArray = FillingArray();
PrintArray(bufferArray);
Console.WriteLine("Введите число для поиска");
int searchNumber = int.Parse(Console.ReadLine());
Console.WriteLine(ColculateTask(bufferArray,searchNumber));