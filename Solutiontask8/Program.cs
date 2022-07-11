string? A = Console.ReadLine();//Задача 8
if(A != null)
{
    int numberA = int.Parse (A);
    int numberB = 2;
    int count = 0;
    while(numberB < numberA)
    {
        count = count + numberB;
        numberB = numberB + 2;
    }
   
        Console.WriteLine(count);
}
