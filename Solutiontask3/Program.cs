string? inputline = Console.ReadLine();

if(inputline != null)
{
    int inputnumber = int.Parse (inputline);
    
    int startNumber = 1;

    string lineOutPut = "0";

    while ( startNumber <= inputnumber)
    {
        lineOutPut = startNumber*(-1)+"," +lineOutPut+","+startNumber;
        startNumber++;
    }

    Console.WriteLine(lineOutPut);
}