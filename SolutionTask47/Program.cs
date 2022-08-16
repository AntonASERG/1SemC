// №47 Задайте двумерный массив размером m×n, заполненный случайными Double (Float)вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//=========================================================================


Console.WriteLine("Задайте размер двухмерного массива - ");
Console.Write("Строки: ");
int countRow = int.Parse(Console.ReadLine());
Console.WriteLine("  ");
Console.Write("Столбы: ");
int countColum = int.Parse(Console.ReadLine());


ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,
                                        ConsoleColor.Cyan,ConsoleColor.DarkBlue,
                                        ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,
                                        ConsoleColor.DarkRed,ConsoleColor.DarkYellow,
                                        ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,
                                        ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};

//метод задать 2д массив, заполненный случайными вещ. числами (type DOUBLE)
double[,] FillingArray2dDouble(int countRow, int countColum)
{
    System.Random numberSintezator = new System.Random();// обращаемся к сист ранд

    int i = 0; int j = 0; // 2 итератора

    double[,] outArray = new double[countRow, countColum];//размер двумерного массива
    while (i < countRow)
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < countColum)
        {
            outArray[i, j] = numberSintezator.NextDouble()*100;
            j++;
        }
        i++;
    }
    return outArray;
}
//  METHOD печать массива 2d в цвете random, type DOUBLE
void PrintRandomColorArray2dDouble(double[,] inputArray)
{
    int i = 0; int j = 0; // 2 итератора

    while (i < inputArray.GetLength(0))// rows
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < inputArray.GetLength(1))// colums
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];//массив col 
            Console.Write(Math.Round(inputArray[i, j],3) + "\t");// (Мат.метод округлить(число, знаки после запятой))+/TAБУЛЯЦИЯ
            Console.ResetColor();// сбросить цвет
            j++;
        }
        Console.Write("\n");// принудительно напечатать конец строки = Сonsole.WriteLine()
        i++;// перейти на строку далее
    }
}

double[,] twoDimArray = FillingArray2dDouble(countRow, countColum);// TYT! задан размер массива!!!!!!
PrintRandomColorArray2dDouble(twoDimArray);

