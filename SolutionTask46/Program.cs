// Задача 46 Задать двухмерный массив со случайнми числами
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

//  METHOD печать массива 2d в цвете
void PrintColorArray2d(int[,] inputArray)// печать массива 2d
{
    int i = 0; int j = 0; // 2 итератора
    Console.ForegroundColor = ConsoleColor.Yellow;//задать цвет всего 16
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

    Console.ResetColor();// сбросить цвет

}

//  METHOD печать массива 2d в цвете random
void PrintRandomColorArray2d(int[,] inputArray)// печать массива 2d
{
    int i = 0; int j = 0; // 2 итератора
    Console.ForegroundColor = ConsoleColor.Yellow;
    while (i < inputArray.GetLength(0))// rows
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < inputArray.GetLength(1))// colums
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];//массив col 
            Console.Write(inputArray[i, j] + " ");// c первой строки все колонки
            Console.ResetColor();// сбросить цвет
            j++;
        }
        Console.Write("\n");// принудительно напечатать конец строки = Сonsole.WriteLine()
        i++;// перейти на строку далее
    }
}


int[,] twoDimArray = FillingArray2d(5, 8);// тут задан размер массива
PrintArray2d(twoDimArray);
PrintColorArray2d(twoDimArray);
PrintRandomColorArray2d(twoDimArray);