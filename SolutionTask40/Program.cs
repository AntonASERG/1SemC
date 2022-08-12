// принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
int a = 0;
int b = 0;
int c = 0;

ReadSides();
Array();
bool result = BoolABC(a,b,c);
PrintBoolAnswer(result);

void ReadSides()//ввести значения сторон
{
    Console.Write("Введите длину стороны А - ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Введите длину стороны B - ");
    b = int.Parse(Console.ReadLine());
    Console.Write("Введите длину стороны C - ");
    c = int.Parse(Console.ReadLine());
}

void Array()// мой метод через массив
{
    int[] triangle = new int[3];
    triangle[0] = a;
    triangle[1] = b;
    triangle[2] = c;

    static int[] BubbleSort(int[] triangle)//Метод ПУЗЫРЬКА!!!
    {
        int temp;//буферная переменная
        for (int i = 0; i < triangle.Length; i++)//предыдущий элемент (i)
        {
            for (int j = i + 1; j < triangle.Length; j++)// последующий (j).
            {
                if (triangle[i] > triangle[j])
                {
                    temp = triangle[i]; //Если  i > j, то меняем элементы местами и продолжаем сравнение дальше
                    triangle[i] = triangle[j];
                    triangle[j] = temp;
                }
            }
        }
        return triangle;
    }
    BubbleSort(triangle);
    if (triangle[2] < triangle[0] + triangle[1])
    {
        Console.WriteLine("Могут образовать треугольник АВС");
    }
    else
    {
        Console.WriteLine("Не могут образовать треугольник АВС");
    }
}

bool BoolABC(int at, int bt, int ct)// метод возвращает значение BOOL
{
    bool answer = ((at+bt>ct)
     && (bt+ct>at) 
     && (at+ct>bt)) ? true : false;// Тринарный оператор
    return answer;
}

void PrintBoolAnswer (bool answer)// метод придает значениям буул ответы
{
    if (answer)
    {
        Console.WriteLine("Могут образовать треугольник АВС");
    }
    else
    {
        Console.WriteLine("Не могут образовать треугольник АВС");
    }
}

