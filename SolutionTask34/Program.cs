// Задача 34 - Массив случайные числа+, показать количество четных *отсортировать пузырьком

Console.Write("Задайте размер массива - ");
int len = int.Parse(Console.ReadLine());

int[] FillingArray() //Задать массив 
{
    int[] outArray = new int[len];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < len)
    {
        outArray[i] = numberSintezator.Next(100, 1000);//Диапазон 3х значных чисел
        i++;
    }
    return outArray;
}

void PrintArray(int[] array)// печать массива
{
    int i = 0;
    while (i < array.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i]);//Допечатать последний элемент массива
}


int Task (int[] array)// Считаем четные числа в массиве
{
    int b = 0;// количество четных чисел
    int i = 0;// итератор
    while (i<array.Length)
    {
        if (array[i]%2 ==0)// четно ли число - элемент массива
        {
            b++;
        }
        else
        {
            b+=0;
        }
        i++;
    }
    return b;
}

static int[] BubbleSort(int[] array)//Метод ПУЗЫРЬКА!!!
        {
            int temp;//буферная переменная
            for (int i = 0; i < array.Length; i++)//предыдущий элемент (i)
            {
                for (int j = i + 1; j < array.Length; j++)// последующий (j).
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i]; //Если  i > j, то меняем элементы местами и продолжаем сравнение дальше
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }
            return array;
        }

int[] bufferArray = FillingArray();
PrintArray(bufferArray);
int[] bubleArray = BubbleSort(bufferArray);
PrintArray(bubleArray);
int total = Task(bufferArray);
Console.WriteLine(total);









//Примечание для меня: выше обсуждалась возможность менять 
//«направление» сортировки, где меньший элемент будет 
//в конце массива, а больший в начале. Для этого надо 
//лишь поменять строку  if (mas[i] > mas[j]) на  if (mas[i] < mas[j]).