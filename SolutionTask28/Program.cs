// Задача 28 Произведение всех чисел от 1 до Числа N

Console.WriteLine("Введите число");

int inputnumber = int.Parse(Console.ReadLine());

void VariantSimple()
{
    int sumOfNumbers = 1;
    for(int i =1; i<=inputnumber; i++)
    {
        sumOfNumbers *= i; //sumOfNumbers = sumOfNumbers * i
    } 
    Console.WriteLine("Произведение чисел от 1 до " + inputnumber + " = " + sumOfNumbers);
}

VariantSimple();
