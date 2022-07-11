string? A = Console.ReadLine();//Задача 6
if(A != null)
{
    int numberA = int.Parse (A);
    int numberB = numberA%2;
    if(numberB == 0)
    {
        Console.WriteLine("четное");
    }
    else
    {
        Console.WriteLine("нечетное");
    }
}