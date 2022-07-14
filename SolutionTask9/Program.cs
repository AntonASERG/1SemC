System.Random numberSintezator = new Random(); //  Задача 9,генератор случайных чисел
//без него число при другой операции потеряется
int number = numberSintezator.Next(10,100);//задали переменную случайным числом

Console.WriteLine(number);//вывести случайное число

int firstnumber = number/10;// показать большую цифру из числа)))
int secondnumber = number%10;
//variant 1 
if(firstnumber>secondnumber)// Klass
{
    Console.WriteLine(firstnumber);//writeline - metod
} else {
    Console.WriteLine(secondnumber);}
// variant 2
int num = new Random().Next(10, 100);//objekt
Console.Write("Ze Random iz:  ");
Console.WriteLine(num);
string srtringNum = num.ToString(); //преврати объект в строку
Console.Write("Ze bolshoe iz:  ");
if(srtringNum[0] > srtringNum[1])
{
    Console.WriteLine(srtringNum[0]);
}else{
    Console.WriteLine(srtringNum[1]);}
// variant 3
// char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
// // + метод для извлечения символов в строке в массив символов
// firstNumber = ((int)digits[0])-48;
// secondNumber = ((int)digits[0])-48;

// int resultNumber = firstnumber>?resultNumber=firstnumber:resultNumber=secondnumber;