string? inputline = Console.ReadLine();

if(inputline != null)
{
    int inputnumber = int.Parse (inputline);
    
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputnumber));
    
    Console.WriteLine(outDayOfWeek);
    
    // string [] dayOfWeek = new string [7];
    // dayOfWeek[0] = "Понедельник";
    // dayOfWeek[1] = "Вторник";
    // dayOfWeek[2] = "Среда";
    // dayOfWeek[3] = "Четверг";
    // dayOfWeek[4] = "Пятница";
    // dayOfWeek[5] = "Шаббат";
    // dayOfWeek[6] = "Воскресенье";

// switch (inputnumber)
//{
    //case 1....7:
    //Console.WriteLine("Понедельник")
    //break;
//}
//     Console.WriteLine(dayOfWeek[inputnumber-1]);
}
