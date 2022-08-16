// // №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
//============================================================================


int countRow = 0;
int countColum = 0;
Console.Write("Задайте число поиска  ");
int searchNum = int.Parse(Console.ReadLine());

int[,] twoDimArray = FillingArray2d(5, 5);// тут задан размер массива
PrintArray2d(twoDimArray);
bool total = SearchElementToArray2d(twoDimArray, searchNum);
PrintBoolResult(total);

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

// Метод - возвращает BOOL - есть ли элемент в массиве
bool SearchElementToArray2d (int[,] inputArray, int a)
{
    bool res = false;
    int i = 0; int j = 0; // 2 итератора

    while (i < countRow)
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < countColum)
        {
            if(inputArray[i, j] == a)
            {
                res = true;
            }
            j++;
        }
        i++;
    }
    return res;
}
void PrintBoolResult(bool res)
{
    if(res == true)
    {Console.WriteLine("число найдено");}
    else
    {Console.WriteLine("число отсутвует");}
}