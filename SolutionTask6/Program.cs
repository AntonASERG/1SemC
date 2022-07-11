string? A = Console.ReadLine();//Задача 4
string? B = Console.ReadLine();
string? C = Console.ReadLine();
if(A != null && B != null && C != null)
{
    int numberA = int.Parse (A);
    int numberB = int.Parse (B);
    int numberC = int.Parse (C);
    if(numberA >= numberB)
    {
        if (numberA >= numberC)
        {
          Console.WriteLine(numberA);  
        }
        else 
        {
         Console.WriteLine(numberC);   
        }
    }
    else
    {
        if (numberB >= numberC)
        {
          Console.WriteLine(numberB);  
        }
        else 
        {
         Console.WriteLine(numberC);   
        }
    }
}
