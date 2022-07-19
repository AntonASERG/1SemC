// Задача №22
// Напишите программу, которая принимает на вхоl число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Например: 5 -> 1, 4, 9, 16, 25.

// List<int> listGen(int number)
// {
//     List<int> numbers = new List<int>();
//     for(int i = 1; i<= number; i++)
//     {
//         numbers.Add(i);
//     }
//     return numbers;
// }

// Console.Write("Enter N:  ");
// string? inputlineN = Console.ReadLine();
// if(inputlineN != null)// чтобы не было пустотой
// {
//     int N = int.Parse(inputlineN);
//     List<int> nums = listGen(N);
//     foreach (var i in nums)
//     {
//         Console.Write(i);
//         Console.Write(" ");
//     }
//     Console.Writeline();

//     foreach (var i in nums)
//     {
//         Console.Write(i*i);
//         Console.Write(" ");
    
//     }
// }

Console.Write("Enter N:  ");
string? inputlineN = Console.ReadLine();
if(inputlineN != null)// чтобы не было пустотой
{
int N = int.Parse(inputlineN);

string? LineN = "";
string? LineNN = string.Empty;// =""
int S = 1;

while(S <= N)
{
    LineN = LineN + S + " ";
    LineNN = LineNN + S*S + " ";
    S++;
}
Console.WriteLine(LineN);
Console.WriteLine(LineNN);
}