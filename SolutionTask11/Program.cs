//задача 12 Y кратно ли X (исправил, но вариант x%y лучше был)

Console.Write("X: ");
string? x = Console.ReadLine();// ? не допускает Null
Console.Write("Y: ");
string? y = Console.ReadLine();

if(x != null && y != null )
{
    int xDigit = int.Parse (x);//ОЧЕНЬ ВАЖНО Parse - перевод в int!!
    int yDigit = int.Parse (y);
    int z = yDigit%xDigit;
    if(z == 0)
    {
        Console.WriteLine("Кратно");  
    }
    else
    {
      Console.Write("Некратно, ");
      Console.WriteLine(z);  
    }
    
}