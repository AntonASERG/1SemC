//Задача 62, задайте  спиральный массив 4x4


//=======================================================================


Console.WriteLine("Задайте размер двухмерного массива - ");
Console.Write("Строки: ");
int countRow = int.Parse(Console.ReadLine());
Console.WriteLine("  ");
Console.Write("Столбы: ");
int countColum = int.Parse(Console.ReadLine());

int[,] spiral = FillSpiralTwoDimArray(countRow,countColum);
PrintArray2d(spiral);

// Метод - задать спиральный массив (скачал из сети и адаптировал в метод)
int[,] FillSpiralTwoDimArray(int countRow, int countColum)
{

    int[,] a = new int[countRow, countColum];

    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = countColum;

    for (int i = 0; i < a.Length; i++)
    {
        a[row, col] = i + 1;// чтобы обратить массив против часовой - поменять местами row и col
        if (--gran == 0)
        {
            gran = countColum * (dirChanges % 2) + countRow * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return a;
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


// ДЛЯ СПрАВКИ - ниже - сидел пытался вывести код сам получилась такая туфта

// // метод для заполнения двумерного массива по спирали
// int[,] FillSpiralTwoDimArray(int countRow, int countColum)
// {
//     int buf = 0;
//     int i = 0; int j = 0;
//     int[,] outArray = new int[countRow, countColum];
//     while (i < countRow)
//     {
//         while (j < countColum)
//         {
//             buf = j;
//             outArray[i, j] = buf;
//             j++;
//         }
//     }
//     i = i + 1;
//     while (j <= countColum - 1)
//     {
//         while (i < countRow)
//         {
//             buf = buf + 1;
//             outArray[i, j] = buf;
//             i++;
//         }
//     }
//     j = j - 1;
//     while (i <= countRow - 1)
//     {
//         while (j >= 0)
//         {
//             buf = buf + 1;
//             outArray[i, j] = buf + 1;
//             j = j - 1;
//         }
//     }
//     i = i - 1;
//     while (j <= 0)
//     {
//         while (i > 0)
//         {
//             buf = buf + 1;
//             outArray[i, j] = buf + 1;
//             i = i - 1;
//         }
//     }
//     j=j+1;
// while (i <= 1)
//     {
//         while (j < countColum-1)
//         {
//             buf = buf + 1;
//             outArray[i, j] = buf + 1;
//             j = j + 1;
//         }
//     }
//     i=i+1;
// while (j <= countColum-2)

//         while (i < countRow-1)
//         {
//             buf = buf + 1;
//             outArray[i, j] = buf + 1;
//             i = i + 1;
//         }
//    j=i-1; 
// while (i <= countRow-2)
//     {
//         while (j > 0)
//         {
//             buf = buf + 1;
//             outArray[i, j] = buf + 1;
//             i = i + 1;
//         }
//     }
// return outArray;
// }




