//Задача 15 Дни недели
Console.Write("Day of week:  ");
string? x = Console.ReadLine();

if(x != null)
{
    int d = int.Parse (x);
    if((d == 6) || (d == 7))
    {
        Console.WriteLine("Выходной");  
    }
    else
    {
        if (d >0 && d < 6)
        {
            Console.WriteLine("Будний"); 
        }
        else
        {
            Console.WriteLine("Вы ввели не то, что надо");
        }
         
    } 
}
