// Без рекурсии вывести первые N чисел в Фибоначи

Console.Write("Cкока нада Фибонач? ");
int decenalNumber = ReadDecenalNumber();
PrintAnswer(Fibonnaci(decenalNumber));

int ReadDecenalNumber()
{
    return int.Parse(Console.ReadLine() ?? "");
}

string Fibonnaci(int n)
{
    string answer = "";
    if (n==2) 
    {
        answer = "0 1";
    }
    else if (n==1)
    {
        answer = "0";
    }
    else
    {
        answer = "0 1";
        int fn_1 = 1;
        int fn_2 = 0;
        int Fn;
        for (int i =0; i <n-2; i++)
        {
            Fn = fn_1 + fn_2;
            answer += " " + Fn;
            fn_2 = fn_1;
            fn_1= Fn;
        }
    }
    return answer;
}

void PrintAnswer(string answer)
{
    Console.WriteLine ("Фибоначи:  " + answer);
}