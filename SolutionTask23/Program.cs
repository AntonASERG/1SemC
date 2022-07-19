// // №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1

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
    LineN = LineN + S + ",";
    LineNN = LineNN + Math.Pow(S,3) + ",";
    S++;
}
// char[] arrayN = LineN.ToCharArray();
// char[] arrayNN = LineNN.ToCharArray();

// char[] combined = LineN.Concat(LineNN).ToArray();
// // char [,] array = new char[1,2];
// // array [0,0] = arrayN;
// // array [0,1] = arrayNN;
//* -выполнить не смог - хотел перевести в двухмерный массив но не удалось

Console.WriteLine(LineN);
Console.WriteLine(LineNN);
}
