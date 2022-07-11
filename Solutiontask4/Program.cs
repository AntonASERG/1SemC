// string? inputline = Console.ReadLine();

// if(inputline != null)
// {
//     int inputnumber = int.Parse (inputline);
    
//     int outputnumber = inputnumber%10; 

//     Console.WriteLine(outputnumber);
// }
string? inputline = Console.ReadLine();// через массив

if(inputline != null)
{
    char[] M = inputline.ToCharArray ();
    Console.WriteLine(M[2]);
}