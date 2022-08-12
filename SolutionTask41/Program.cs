// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
//======================================================================================
Console.Write("Задайте размер массива - ");
int m = int.Parse(Console.ReadLine());
int[] num = new int [m];

int [] total = Read(m);
int res = Calculate(total);
Print(res);



int[] Read (int m)// метод, чтобы пользователь ввел числа
{
int[] buffer = new int [m];
for (int i = 0; i < m; i++)
{
    buffer[i] = int.Parse(Console.ReadLine());
}
return buffer;
}

int Key(int[] buffer)
{
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if ((key.key == NumPad-) && (key.key == D-)  )
}

int Calculate (int[] buffer)
{
    int b =0;
    for (int i =0; i < buffer.Length; i++)
    {
        if (buffer[i] > 0)
        {
            b++;
        }
    }
    return b;
}

void Print (int b)
{
    Console.WriteLine("больше нуля   "+b+"   чисел");
}