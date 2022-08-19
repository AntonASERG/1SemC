// Задача 56: Задайте прямоугольный двухмерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
//==================================================================

//метод задает рандомный 2д массив
int[,] FillingArray2d(int countRow, int countColum)
{
    System.Random numberSintezator = new System.Random();// обращаемся к сист ранд

    int i = 0; int j = 0; // 2 итератора

    int[,] outArray = new int[countRow, countColum];//размер двумерного массива

    while (i < countRow)
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < countColum)
        {
            outArray[i, j] = numberSintezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

//  METHOD печать массива 2d
void PrintArray2d(int[,] inputArray)// печать массива 2d
{
    int i = 0; int j = 0; // 2 итератора
    while (i < inputArray.GetLength(0))// rows
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < inputArray.GetLength(1))// colums
        {
            Console.Write(inputArray[i, j] + " ");// c первой строки все колонки
            j++;
        }
        Console.Write("\n");// принудительно напечатать конец строки = Сonsole.WriteLine()
        i++;// перейти на строку далее
    }

}

//  ищет строку с минимальной суммой
int GetMinSumOfArrayRow(int[,] inputArray)
{
    int index = 0;
    int i = 0; int j = 0; // 2 итератора
    int b = 0; //накопитель
    int min = 100000;// не могу понять какое значение задать мин изнчально
    while (i < inputArray.GetLength(0))// rows
    {
        j = 0;// ОБНУЛИТЬ J
        b = 0;
        while (j < inputArray.GetLength(1))// colums
        {
            b = b+=inputArray[i,j]; //сумма строки
            j++;
            
            if(b<min)
            {
                min = b;
                index = i;
            }
        }
    i++;
    }
    return index;
}

Console.WriteLine("Исходный массив:  ");
int[,] bufferArray = FillingArray2d(3, 3);
PrintArray2d(bufferArray);
int ind = GetMinSumOfArrayRow(bufferArray);
Console.WriteLine("Минимальная сумма содержится в "+ ind + " строке");
