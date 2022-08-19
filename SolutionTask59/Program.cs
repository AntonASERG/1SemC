//Задача 59, задайте 2д массив целых чисел
// Программа - программа удалить столбец и строку где наименьшее число

//=======================================================================


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

// Метод - Удаление строки и столба по элементу
int[,] DeleteCrossArray2d(int[,] inputArray, int row, int colum)
{
    int[,] outArray = new int[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1];// на строку и стол меньше
    int bufferElement = 0;// буффер
    int i = 0; int j = 0; // 2 итератора 
    int k = 0; int m = 0;// 2 итератора массива Array - !!!
    while (i < inputArray.GetLength(0))
    {
        j = 0;// обнулить чтоб с начала
        m = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i != row && j != colum)
            {
                outArray[k, m] = inputArray[i, j];
            }
            if (j != colum)
            {
                m++;
            }
            j++;
        }
        if (i != row)k++;
        i++;
    }
    return outArray;
}

// метод найти мин элемент
int[] FindMinElement(int[,] matrix)
{
    int[] array = new int[] { 0, 0 };//значения
    int minElement = int.MaxValue;// присвоить макс значение
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] == minElement)
            {
                array[0] = i;
                array[1] = j;
            }
    }
    return array;
}



int[,] twoDimArray = FillingArray2d(5, 5);// тут задан размер массива
PrintArray2d(twoDimArray);
Console.WriteLine();

int[]indexes = FindMinElement(twoDimArray);
int[,]buffer2d = DeleteCrossArray2d(twoDimArray, indexes[0],indexes[1]);
PrintArray2d(buffer2d);


