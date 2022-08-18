//Задача 57, Создать частотный словарь элементов двумерного массива
// инфа - сколько раз элемент встречается в исх данных
//=======================================================================
// используй метод сортировки подсчета он крут

// array = [1,2,3,4,2,1,3,2,4,2,3,7] массив
//alphabet = [1,2,3,4,7] алфавит
// freqmancy = [2,4,2,1] сколько частот
// 

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
            outArray[i, j] = numberSintezator.Next(0, 10);
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

// Метод печать 1д массив
void PrintArray(int[] array)
{
    int i = 0;
    while (i < array.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i]);//Допечатать последний элемент массива
}

// Метод - частотный словарь
int[] FreqmancyCollect(int[,] inputArray, int alphabetLength)
{
    int[] resultArray = new int[alphabetLength];// длина 
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))//! квадратный массив пох
    {
        j = i;// чтобы пройти по диагонали и упростить код
        while (j < inputArray.GetLength(1))//!
        {
            // array = [1,2,3,0,2,1,3,2,0,2,3,0] массив
            //alphabet = [0,1,2,3] алфавит
            // freqmancy = [3,2,4,3] сколько частот

            resultArray[inputArray[i, j]]++;// cобираем частоту появления элементов
            j++;
        }
        i++;
    }
    return resultArray;
}

int[,] twoDimArray = FillingArray2d(10, 10);// тут задан размер массива
PrintArray2d(twoDimArray);
Console.WriteLine();
int [] total = FreqmancyCollect(twoDimArray,10);// 10 - alphabetLength
PrintArray(total);

