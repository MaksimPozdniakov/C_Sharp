//Задача №1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Input x ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)} quart");
*/

//Задача №2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). 
/*
void Diaposon(int num)
{
    if(num < 0 || num > 4) Console.Write("Input uncorrect number ");
    if(num == 1) Console.WriteLine("x > 0, y > 0");
    if(num == 2) Console.WriteLine("x < 0, y > 0");
    if(num == 3) Console.WriteLine("x < 0, y < 0");
    if(num == 4) Console.WriteLine("x > 0, y < 0");
}
Console.Write("Enter the quart ");
int a = Convert.ToInt32(Console.ReadLine());
Diaposon(a);
*/

//Задача №3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//Помочь решить данную задачу может Теорема Пифагора. Определение: в прямоугольном треугольнике квадрат длины гипотенузы равен сумме квадратов длин катетов.
/*
double Rasstoynie(double xA, double yA, double xB, double yB)
{
    double ab;
    ab = Math.Sqrt(Math.Pow(xB-xA,2) + Math.Pow(yB - yA,2));
    return Math.Round(ab,2);
}
Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write(Rasstoynie(xA, xB, yA, yB));
*/
//Задача №4. Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
/*
void Method(int n)
{
    int count = 1;
    while (count <= n)
    {
      Console.WriteLine($"{Math.Pow(count,2)} ");
      count++; 
    }
}
Console.Write("Input number ");
int a = Convert.ToInt32(Console.ReadLine());
Method(a);
*/