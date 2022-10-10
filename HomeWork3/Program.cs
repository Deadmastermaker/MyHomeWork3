// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double Distance (double ax,double ay,double az,double bx,double by,double bz)
{
    return Math.Sqrt(Math.Pow((ax - bx),2) + Math.Pow((ay - by),2) + Math.Pow((az - bz),2));
}

Console.Write("Input ax: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ay: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Input az: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.Write("Input bx: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Input by: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Input bz: ");
double bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{ax},{ay},{az}");
Console.WriteLine($"{bx},{by},{bz}");
Console.WriteLine($"Distance = {Math.Round(Distance(ax,ay,az,bx,by,bz),2)}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void CubDigit(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine(Math.Pow(count,3));
        count++;
    
    }
}

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
CubDigit(num);
*/

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


/*void NumberPol(int num)

{

if(num < 10000 && num > 99999)
{
    Console.WriteLine("Not Found");
}
else
{
    
    int firstnum = num / 10000;
    int secondnum = num % 10;
    if(firstnum == secondnum)
    {
        int NewNumber = num % 10000 / 10;
        firstnum = NewNumber / 100;
        secondnum = NewNumber % 10;
        if (firstnum == secondnum)
        Console.WriteLine($"{num} = палиандр");
     else
        Console.WriteLine("Not Found 2");

    }
else
Console.WriteLine("Not Found 1");
}
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
NumberPol(number);

*/


