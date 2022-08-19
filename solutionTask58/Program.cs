// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
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
            Console.Write(inputArray[i, j] + "\t");// c первой строки все колонки
            j++;
        }
        Console.Write("\n");// принудительно напечатать конец строки = Сonsole.WriteLine()
        i++;// перейти на строку далее
    }

}

//  ищет строку с минимальной суммой
int [,] MultiplyTwoMatrix(int[,] inputArray, int[,] altArray)
{
    int[,] outarray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    int i = 0; int j = 0; // 2 итератора
    while (i < inputArray.GetLength(0))// rows
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < inputArray.GetLength(1))// colums
        {
            outarray[i, j] = inputArray[i, j] * altArray[i, j];
            j++;
        }
        i++;
    }
    return outarray;
}

Console.WriteLine("массив 1");
int[,] firstArray = FillingArray2d(4, 4);
PrintArray2d(firstArray);
Console.WriteLine();
Console.WriteLine("массив 2");
int[,] secondArray = FillingArray2d(4, 4);
PrintArray2d(secondArray);
int[,] resultArray = MultiplyTwoMatrix(firstArray, secondArray);
Console.WriteLine();
Console.WriteLine("произведение двух массивов");
PrintArray2d(resultArray);

