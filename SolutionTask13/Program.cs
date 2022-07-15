//Задача 10 ABC->B
string? x = Console.ReadLine();

if(x != null)
{
    char [] arr = x.ToCharArray();
    int length = arr.Length;  
        if(length > 3)
        {
            Console.WriteLine(arr[2]);  
        }
        else
        {
            Console.WriteLine("Третьей цифры нет"); 
        } 
}
