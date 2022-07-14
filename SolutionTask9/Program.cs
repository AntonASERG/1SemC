//Задача 9

void variant1(System.Random numberSintezator)// (переменная),  решение внутри метода
{
int number = numberSintezator.Next(10,100);//задали переменную случайным числом

Console.WriteLine(number);//вывести случайное число

int firstnumber = number/10;// показать большую цифру из числа)))
int secondnumber = number%10;

if(firstnumber>secondnumber)// Klass
{
    Console.WriteLine(firstnumber);//writeline - metod
} else {
    Console.WriteLine(secondnumber);}
}

void variant2()
{
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
}

void variant3(System.Random numberSintezator)
{
// variant 3 
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
// + метод для извлечения символов в строке в массив символов
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;//не забудь переменные перенести!
int secondNumber = ((int)digits[0])-48;//не забудь переменные перенести!
int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);
}

System.Random numberSintezator = new Random(); //  генератор случайных чисел
//без него число при другой операции потеряется

variant1(numberSintezator);
//variant2();//отключить метод
variant3(numberSintezator);