// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if (n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

ShowNums(5);
*/
// Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
/*
int Sum(int n)
{
    if (n != 0) return Sum(n / 10) + n % 10;
    else return 0;
}

Console.Write(Sum(22));
*/
// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// перерешать
/*
void ShowNums(int n, int m)
{
    if (n > m) ShowNums(m, n - 1);

    Console.Write(n + " ");
}
int m = 1;
int n = 5;
ShowNums(m,n);
*/
/*
void ShowNums(int n, int m)
{
    if (m > n)
    {
        Console.Write(m + " ");
        ShowNums(m - 1, n);
    }
    if (n > m)
    {
        ShowNums(m, n-1);
        Console.Write(n + " ");
    }
    if (m==n)
    {
        Console.Write(m + " ");
    }
}

int m = 5;
int n = 1;
ShowNums(m,n);
*/
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B.
/*
double PowAB(double a, double b)
{
    if (b < 0) return 1 / a * PowAB(a, b + 1);
    if (b > 0) return a * PowAB(a, b - 1);
    else return 1;
}

Console.WriteLine(PowAB(2,-3));
*/