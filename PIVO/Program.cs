// За пивом - неудачно - не могу понять как :(
System.Random numberSint = new Random();
Console.WriteLine("Введите имена: ");
string? inputLineNames = Console.ReadLine();
string[] names = inputLineNames.Split(new char[] { ',' });
int len = names.Length;
int i = numberSint.Next(0,len);
Console.WriteLine(names[i]);