//Задача 11? abc -> ac

void variant1(System.Random numberSintezator)
{
int number = numberSintezator.Next(100,1000);
Console.WriteLine(number);//вывести случайное число

int a = number/100;
int b = number%10;
int result = a*10 + b;

Console.WriteLine(result);
}
void variant2(System.Random numberSintezator)
{
int number = numberSintezator.Next(100,1000);
Console.Write("Было: ");
Console.WriteLine(number);
string sn = number.ToString();
Console.Write("Стало: ");
Console.Write(sn[0]);
Console.WriteLine(sn[2]);
}

System.Random numberSintezator = new Random(); 

variant1(numberSintezator);
variant2(numberSintezator);