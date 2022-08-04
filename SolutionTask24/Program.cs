// Задача 24 Сумма всех чисел от 0 до Числа

Console.WriteLine("Введите число");

int inputnumber = int.Parse(Console.ReadLine());
int t;// Время переменная

void VariantSimple()
{
    int sumOfNumbers = 0;
    for(int i =1; i<=inputnumber; i++)
    {
        sumOfNumbers += i; //sumOfNumbers = sumOfNumbers + i
    } 
    Console.WriteLine("Сумма чисел от 1 до " + inputnumber + " = " + sumOfNumbers);
}
void VariantProgressive()
{

    int sumOfNumbers = ((inputnumber+1)*inputnumber)/2;
    Console.WriteLine("Сумма чисел от 1 до " + inputnumber + " = " + sumOfNumbers);
}
t = Environment.TickCount; // время выполнения команды компом

VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);
VariantProgressive();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

// Кривые ответы из-за переполнения типов