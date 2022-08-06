//Задача 25 Принимает А и В, отдает а**в
int a = 0;
int b = 0;

void Read()
{
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
}
int CalculatePow()
{
return (int) Math.Pow(a,b);
}

void CalculateI()
{
    int i = 0;
    int c = 1;
    while (i<b)
    {
        c = c*a;
        i++;
    }
}

void Print()
{
int c = CalculatePow();
Console.WriteLine(c);
}

Read();
//CalculatePow();
CalculateI();
Print();