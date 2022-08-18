// Задайте двумерный массив. 
//Программа меняет первую и последнююстроку массива

//=========================================================================


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

// Метод - блок замены 1 и последней строки 2д массива
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;// буффер
    int i = 0; int j = 0; // 2 итератора 

    while (j < inputArray.GetLength(1))// пробегаем только по j , i неизменен
    {
        bufferElement = inputArray[0, j];
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        inputArray[inputArray.GetLength(0) - 1, j] = bufferElement;
        j++;
    }
    return inputArray;
}


int[,] twoDimArray = FillingArray2d(5, 8);// тут задан размер массива
PrintArray2d(twoDimArray);
Console.WriteLine();
int[,] rotate = RotateRowFirstLast(twoDimArray);
PrintArray2d(rotate);
