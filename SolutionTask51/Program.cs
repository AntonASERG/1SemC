// Задайте двумерный массив. Найдите суммe элементов,
//находящихся на главной диагонали с индексами (0,0); (1;1) и т.д


//=========================================================================

//метод задает рандомный 2д массив

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,
                                        ConsoleColor.Cyan,ConsoleColor.DarkBlue,
                                        ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,
                                        ConsoleColor.DarkRed,ConsoleColor.DarkYellow,
                                        ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,
                                        ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};

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
//  METHOD печать массива 2d в цвете random
void PrintRandomColorArray2d(int[,] inputArray)// печать массива 2d
{
    int i = 0; int j = 0; // 2 итератора

    while (i < inputArray.GetLength(0))// rows
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < inputArray.GetLength(1))// colums
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];//массив col 
            Console.Write(inputArray[i, j] + "\t");// TAБУЛЯЦИЯ
            Console.ResetColor();// сбросить цвет
            j++;
        }
        Console.Write("\n");// принудительно напечатать конец строки = Сonsole.WriteLine()
        i++;// перейти на строку далее
    }
}

int CalDiagTwoDimArr(int[,] inputArray)// Метод считает сумму диагонали 1.1 2.2 3.3
{
    int outSumDiagonal = 0;
    int i = 0;  // 2 итератора  j = i

    while (i < inputArray.GetLength(0))// rows
    {
         outSumDiagonal = outSumDiagonal+inputArray[i,i];
        //Оптимизация кода - убрать все про j тк он = i
        i++;// перейти на строку далее
    }
    return outSumDiagonal;
}


int[,] twoDimArray = FillingArray2d(5, 8);// тут задан размер массива
PrintRandomColorArray2d(twoDimArray);// Табуляция

int sum = CalDiagTwoDimArr(twoDimArray);
Console.WriteLine(sum +"\t");