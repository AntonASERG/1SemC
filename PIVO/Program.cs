// За пивом - неудачно - не могу понять как :(
System.Random numberSint = new Random();
Console.WriteLine("Введите имена: ");
string? names = Console.ReadLine();
char[]array = names.ToCharArray();
int len = array.Length;
int i = numberSint.Next(0,len);
Console.WriteLine(array[i]);