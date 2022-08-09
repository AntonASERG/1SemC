// Задача 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Задайте размер массива - ");
int len = int.Parse(Console.ReadLine());

int[] FillingArray() //Задать массив 
{
    int[] outArray = new int[len];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < len)
    {
        outArray[i] = numberSintezator.Next(1, 20);//Диапазон 3х значных чисел
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


int SumOfOddI (int[] array)// Сумма нечетных индексов
{
    int b = 0;// сумма НЧ индексов
    int i = 1;// итератор - с перевого нечетного числа
    while (i<array.Length)
    {
        b = b+array[i];
        i+=2; // позволяет не трогать четные индексы и облегчает код
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

void Para (int[] array)// вывести пары в массиве
{
    int i = 0;// итератор 
    while (i<array.Length-1)// ОЧЕНЬ ВАЖНО -1 иначе ошибка вызода за пределы массива!
    {
        if(array[i] == array[i+1])// сравнить элементы
        {
            Console.WriteLine(array[i]+" - "+array[i]);
        }
        else
        {
            Console.WriteLine("Нет пар");
        }
        i++;
    }

}


int[] bufferArray = FillingArray();
PrintArray(bufferArray);
int[] bubleArray = BubbleSort(bufferArray);
PrintArray(bubleArray);
Para(bubleArray);
int total = SumOfOddI(bufferArray);
Console.Write("Сумма = ");
Console.WriteLine(total);

