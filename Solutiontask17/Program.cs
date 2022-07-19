// Задача №17 Координаты 
// Метод вводит точки и возвращает массив с ними
int [,] readdoint()//возвр функция 
{
    string inputline =  Console.ReadLine();
    
    // X=34, Y=30 -> 4

    string coordXline = inputline.Substring(0, inputline.IndexOf(";"));// X=34
    coordXline = coordXline.Substring(coordXline.IndexOf("=")+1);// 34

    string coordYline = inputline.Substring(inputline.IndexOf(";")+1);
    coordYline = coordYline.Substring(coordYline.IndexOf("=")+1);
    
//  Console.WriteLine(coordXline+" "+coordYline);
  
    int coordX = int.Parse (coordXline);//Сделали строки вещественными
    int coordY = int.Parse (coordYline);

    int [,] arrayOut = new int[1,2]; //добавили 2д масссив строка и колонка 
    arrayOut [0,0] = coordX;// строка 1 столбец 1 (индексы)
    arrayOut [0,1] =coordY;// строка 1 столбец 2

    return arrayOut; //выдаем массив на выход
}

// Метод печатает номер четверти
void printQuter(int[,] arrayPoint)
{
if(arrayPoint [0,0]>0 && arrayPoint [0,1]>0)
Console.WriteLine ("1 четверть");
if(arrayPoint [0,0]<0 && arrayPoint [0,1]>0)
Console.WriteLine ("2 четверть");
if(arrayPoint [0,0]<0 && arrayPoint [0,1]<0)
Console.WriteLine ("3 четверть");
if(arrayPoint [0,0]>0 && arrayPoint [0,1]<0)
Console.WriteLine ("4 четверть");
}
// ИТОго:
int[,] arrayPoint = readdoint();
printQuter(arrayPoint);