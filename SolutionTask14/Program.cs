//задача 14 X кратно ли 7 & 23 

Console.Write("X: ");
string? x = Console.ReadLine();// ? не допускает Null

if(x != null)
{
    int xDigit = int.Parse (x);//ОЧЕНЬ ВАЖНО Parse - перевод в int!!
    int y = xDigit%7;
    int z = xDigit%23;
    if(z == 0 && y == 0) //&& -u, || - или
    {
        Console.WriteLine("Кратно");  
    }
    else
    {
      Console.WriteLine("Некратно"); 
    }
    
}