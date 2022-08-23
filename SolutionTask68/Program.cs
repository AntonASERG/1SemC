// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

//======================================================================

Console.Clear();// чистит консоль при запуске

int numM = ReadData("Задайте число M - ");
int numN = ReadData("Задайте число N - ");
int akkerMan = 0;

if (numM < 0 || numN < 0)
{
    Console.WriteLine("Читай внимательнее условие задачи!!!");
}
else
{
    akkerMan = A(numM, numN);
    Console.WriteLine(akkerMan);
}
// метод - задать целое число через строку
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine());// возвр число
}
// метод функция Аккермана - скачена из интернета (комменты - как сам понял)
static int A(int m, int n)
{
    if (m == 0) return n + 1; // точка остановки
    if (m != 0 && n == 0) return A(m - 1, 1);// выводит к точке остановки если m>n
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));// подсчет для двух положит. чисел
    return A(m, n);
}
Console.ReadKey();// method  - нажать любую кнопку для.....в данном случае выхода из проги