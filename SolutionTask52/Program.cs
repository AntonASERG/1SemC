// №52 Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждомстолбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
//==========================================================================

Console.WriteLine("Задайте размер двухмерного массива - ");
Console.Write("Строки: ");
int countRow = int.Parse(Console.ReadLine());
Console.WriteLine("  ");
Console.Write("Столбы: ");
int countColum = int.Parse(Console.ReadLine());

int[,] twoDimArray = FillTwoDimArray(countRow, countColum);// тут задан размер массива
PrintArray2d(twoDimArray);
double[] sum = ColumsSum(twoDimArray);
double[] average = ColumsAverage(sum, countRow);
Console.WriteLine("Среднее арифметическое значение по столбам");
PrintArrayDOUBLE(average);

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

//  METHOD печать массива 2d
void PrintArray2d(int[,] inputArray)
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

// метод сумма  столбов в массиве
double[] ColumsSum (int[,] inputArray)
{
    double[] outArray = new double[inputArray.GetLength(1)];
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            outArray[j] += inputArray[i,j];
            j++;
        }
        i++;
    }
    return outArray;
}



// метод среднее арифметическое в столбах
double[] ColumsAverage (double[]inputArray,int countRow)
{
    double[] outArray = new double[inputArray.Length];
    int i = 0;
    while(i<inputArray.Length)
    {
        outArray[i] = inputArray[i]/countRow;
        i++;
    }
    return outArray;
}

//  METHOD печать массива  DOUBLE
void PrintArrayDOUBLE(double[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(Math.Round(inputArray[i],3) + "\t");
        i++;  
    }
    Console.WriteLine(Math.Round(inputArray[i],3));//Допечатать последний элемент массива
}
