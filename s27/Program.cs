//Задача 27 Сумма цифр в числе

string intA = Console.ReadLine();
int b = 0;
DateTime timePoint = DateTime.Now;
void Calk1()
{
    int a = int.Parse(intA);
    while (a > 10)// прослушал про а > 0
    {
        b = b + a%10;
        a = a / 10;
    }
    b = b+a;// xe xe xe.....чтоб 1 цифра не вылетала
}

void Calk2()
{
    char[] array = intA.ToCharArray();//Не работает - не пойму почему!
    int i = 0;
    int len = array.Length;
    while (i<len)
    {
        b = b + array[i];
        i++;
    }
}

timePoint = DateTime.Now;
Calk1();
Console.WriteLine(b);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
Calk2();
Console.WriteLine(b);
Console.WriteLine(DateTime.Now - timePoint);
