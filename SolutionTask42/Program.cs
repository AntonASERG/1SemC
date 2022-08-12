// Задача 42 перевод из десятеричной в двоичную
Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()),2));

int number = int.Parse(Console.ReadLine());
string outline = Convert.ToString(number,2);// метод в Тустринге - 2 система счисления
Console.WriteLine(outline);


// Строчки разбираются изнутри!!!
//Расписать  обычный алгоритм - он быстрее!!