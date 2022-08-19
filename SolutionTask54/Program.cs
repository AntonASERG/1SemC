// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

//Метод ПУЗЫРЬКА для 2 д массива
int[,] BubbleSortRowsIn2dArray(int[,] array)
{
    
    int temp;//буферная переменная
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        j = 0;
        while (j < array.GetLength(1))
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,k] > array[i,j])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = temp;
                }
            }
        j++;
        }
    }
    return array;
}

Console.WriteLine("Исходный массив:  ");
int[,] bufferArray = FillingArray2d(3, 3);
PrintArray2d(bufferArray);
Console.WriteLine("Строки по убыванию: ");
int[,] sortArray = BubbleSortRowsIn2dArray(bufferArray);
PrintArray2d(sortArray);

