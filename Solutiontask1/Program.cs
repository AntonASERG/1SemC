string? inputA = Console.ReadLine();
string? inputB = Console.ReadLine();

if(inputA != null && inputB != null)
{
    int inputnumberA = int.Parse (inputA);
    int inputnumberB = int.Parse (inputB);

    if(inputnumberA == Math.Sqrt(inputnumberB))
    {
        Console.WriteLine("YES");
    }
    else
    {
       Console.WriteLine("NO");
    } 
}
    

   