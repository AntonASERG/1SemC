//задача X=Y*Y ?

Console.Write("X: ");
string? x = Console.ReadLine();// ? не допускает Null
Console.Write("Y: ");
string? y = Console.ReadLine();

if(x != null && y != null )
{
    int xDigit = int.Parse (x);//ОЧЕНЬ ВАЖНО Parse - перевод в int!!
    int yDigit = int.Parse (y);
    if(xDigit == yDigit*yDigit)
    {
        Console.WriteLine("Да");  
    }
    else
    {
      Console.WriteLine("Нет");  
    }
    
}