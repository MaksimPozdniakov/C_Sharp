// МЕТОДЫ!! 

//Задача №1. Необходимо написать программу, которая выводит 
//случайное число из отрезка от 10 до 99 и показывает нибольшуу 
//цифру данного числа.
/*
int FindBiggestDigit(int num)
{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec)
        max = ed;
    else
        max = dec;

    return max;
}

int number = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Задача №2. Нобходимо написать программу, которая выводит 
//случайное 3-х значное число и удаляет вторую цифру этого числа.
/*
int RandomDigit(int num)
{
    int result;

    int ed = num % 10;
    int dec = num / 100;

    result = dec * 10 + ed;

    return result;
}

int number = new Random().Next(100, 1000);
int result = RandomDigit(number);

Console.WriteLine($"Digit {number} is {result}");
*/

// Задача №3. Необходимо написать программу, которая принимает 
//на вход число N (целое) и проверяет кратно ли оно одновременно
//a и b (это тоже входящие данные).   
/*
bool MultipleNumber(int number, int a, int b)
{
    bool result;
    if (number % a == 0 && number % b == 0)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input First Number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Second Number ");
int b = Convert.ToInt32(Console.ReadLine());

bool result = MultipleNumber(number, a, b);
Console.WriteLine(result);
*/