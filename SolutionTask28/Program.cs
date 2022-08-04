// Задача 28 Произведение всех чисел от 1 до Числа N

Console.WriteLine("Введите число");
string? inputline = Console.ReadLine();
int inputnumber = int.Parse(inputline);

int t;// Время переменная

t = Environment.TickCount; // время выполнения команды компом
Console.WriteLine(VariantSimple(inputnumber));
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount; // время выполнения команды компом
Console.WriteLine(mulRec(inputnumber));
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

int VariantSimple(int num)
{
    int sum = 1;
    for(int i =1; i<=inputnumber; i++)
    {
        sum *= i; //sum = sum * i
    }
    return sum;
}

int mulRec(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * mulRec(num - 1);
    }
}
