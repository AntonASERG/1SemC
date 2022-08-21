// // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных
//  чисел. Напишите программу, которая будет построчно выводить массив,
//   добавляя индексы каждого элемента.массив размером 2 x 2 x 2

//метод задает рандомный 3д массив
int[,,] FillingArray3d(int countRow, int countColum, int countFat)
{
    System.Random numberSintezator = new System.Random();// обращаемся к сист ранд

    int i = 0; int j = 0; int k = 0; // 3 итератора

    int[,,] outArray = new int[countRow, countColum,countFat];//размер двумерного массива

    while (i < countRow)
    {
        j = 0;// ОБНУЛИТЬ J
        while (j < countColum)
        {
            k = 0;
            while (k < countFat)
            {
                outArray[i, j, k] = numberSintezator.Next(10, 100);
                if (outArray.Contains(numberSintezator))
                {
                    i--;
                    j--;
                    k--;
                }
                else
                {
                    outArray[i,j,k] = numberSintezator;
                }
                k++;
            }
            j++;
        }
        i++;
    }
    return outArray;
}

//  METHOD печать массива 3d 
void PrintArray3d(int[,,] inputArray)
{
    int i = 0; int j = 0; k=0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            k=0;
            while (k < inputArray.GetLength(2))
            {
            Console.Write(inputArray[i, j, k] + "\t");
            k++;
            }
            Console.Write("\n");
            j++;
        }
        i++;
    }

}

int [,,] a = FillingArray3d(2,2,2);
PrintArray3d(a);
// num
// list<int> number
// int (,,) A
// while
// {
//     if
//     {
//         (number.contain)
//     }

//     else
//     {

//         a
//     }
//     NullableComparer random random.next
// }
// print

// массив спирально