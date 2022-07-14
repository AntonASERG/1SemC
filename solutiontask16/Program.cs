//задача X=Y*Y  или Y= x*x

Console.Write("X: ");
string? x = Console.ReadLine();
Console.Write("Y: ");
string? y = Console.ReadLine();

if(x != null && y != null )
{
    int xDigit = int.Parse (x);
    int yDigit = int.Parse (y);
    if(xDigit == yDigit*yDigit)
    {
        Console.WriteLine("X квадрат от Y");  
    }
    else
    {
      if(yDigit == xDigit*xDigit)
      {Console.WriteLine("Y квадрат от X");
      }
      else
      {
        Console.WriteLine("Нет");  
      }
    }   
}