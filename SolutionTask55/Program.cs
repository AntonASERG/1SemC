// Метод ввода переменных, принимает число и выводит его
// int ReadCoord(string line)
// {
//     Console.WriteLine(line);// принцип капсуляции
//     int buffer = int.Parse(Console.ReadLine());
//     Console.WriteLine("Вы ввели число  "+ buffer);
//     return buffer;
// }

// int a = ReadCoord("Введите число А:  ");
// int b = ReadCoord("Введите число B:  ");
// int c = ReadCoord("Введите число C:  ");

//Задача 55, задайте 2д массив
// Программа - заменить строки на столбы или вывести сообщение что невозможно

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

// Метод - замена строк на столбы или сообщение
int[,] RotateRowsColums(int[,] inputArray)
{
    int bufferElement = 0;// буффер
    int i = 0; int j = 0; // 2 итератора 

    while (i < inputArray.GetLength(1))//! квадратный массив пох
    {
        j = i;// чтобы пройти по диагонали и упростить код
        while (j < inputArray.GetLength(0))//!
        {
            bufferElement = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = bufferElement;
            j++;
        }
        i++;
    }
    return inputArray;
}

int[,] twoDimArray = FillingArray2d(5, 5);// тут задан размер массива
PrintArray2d(twoDimArray);
Console.WriteLine();
if (twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
{
    Console.WriteLine("Данный массив повернуть нельзя!");
}
else
{
    int[,] rotate = RotateRowsColums(twoDimArray);
    PrintArray2d(rotate);
}

