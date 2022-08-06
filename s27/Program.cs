//Задача 27 Сумма цифр в числе

string intA = Console.ReadLine();
int b = 0;

void Calk1()
{
    int a = int.Parse(intA);
    while (a > 10)
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
//Calk1();
Calk2();
Console.WriteLine(b);