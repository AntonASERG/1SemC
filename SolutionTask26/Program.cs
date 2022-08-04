// Задача 26 количество цифр в числе

Console.WriteLine("Введите число");

string inputLineNumber = Console.ReadLine() ?? "";
int inputnumber = int.Parse(inputLineNumber);

DateTime timePoint = DateTime.Now;//Задаем переменную Таймпоинт

int VariantChar()
{
    // int numberLength = 0;

    // char[] array = inputLineNumber.ToCharArray(); //Преобразование в массив строки
    // numberLength = array.Length;
    // return numberLength;
    return inputLineNumber.ToCharArray().Length;//!!!То же самое только короче - строка в массив и вызвать длину
}

int WariantSimle()
{
   int numberl = 0;
   int digits = 1; 
   while(digits < inputnumber)
   {
    digits=digits*10;
    numberl++;
   }
return numberl;
}

int VariantLog()
{
    return (int)Math.Log10(inputnumber)+1;//!!!!Принудительное возвращение типов
}

int result = 0;

timePoint = DateTime.Now;//Задаем исх Таймпоинт
result = VariantChar();
Console.WriteLine(result);
Console.WriteLine( DateTime.Now - timePoint);//Таймпоинт выполнения

timePoint = DateTime.Now;//Задаем исх Таймпоинт
result = WariantSimle();
Console.WriteLine(result);
Console.WriteLine( DateTime.Now - timePoint);//Таймпоинт выполнения

timePoint = DateTime.Now;//Задаем исх Таймпоинт
result = VariantLog();
Console.WriteLine(result);
Console.WriteLine( DateTime.Now - timePoint);//Таймпоинт выполнения

// для больших чисел меняем переменную int (4 байта) на long (8 байт ) и т д