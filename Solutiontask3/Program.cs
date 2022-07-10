string? inputline = Console.ReadLine();

if(inputline != null)
{
    int inputnumber = int.Parse (inputline);
    
    int startNumber = (inputnumber * -1);

    string lineOutPut = "";

    while ( startNumber < inputnumber)
    {
        lineOutPut = lineOutPut+startNumber+",";
        startNumber++;
    }

    Console.WriteLine(lineOutPut);
}