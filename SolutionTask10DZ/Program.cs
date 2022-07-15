//Задача 10 ABC->B
string? x = Console.ReadLine();
void VAR1()
{
if(x != null)
    {
        int xDigit = int.Parse (x);//ОЧЕНЬ ВАЖНО Parse - перевод в int!!
        if(xDigit > 99 && xDigit < 1000)
        {
            int yDigit = xDigit%100;
            int zDigit = yDigit/10;
            Console.WriteLine(zDigit);  
        }
        else
        {
            Console.WriteLine("Вы ввели не трехзначное число"); 
        } 
    }
}  

void VAR2()//Варту
{
    if(x != null)
    {
    string sn = x.ToString();
    int xDi = int.Parse (x);
        if(xDi > 99 && xDi < 1000)
        {
            Console.WriteLine(sn[1]);  
        }
        else
        {
            Console.WriteLine("Вы ввели не трехзначное число"); 
        } 
    }
}

VAR1();
VAR2();