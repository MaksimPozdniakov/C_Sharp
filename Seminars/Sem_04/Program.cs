// проверить все решения начиная с этого семинара

/*
int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
    {
        sum += current;
    }
    return sum;
}

Console.Write("Input positive integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

int s = GetSum(b);
Console.WriteLine($"Sum of elements from 1 to {b} is {s}");
*/

// Задача №1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/* 
int CountNumber(int num)
{
    int count = 0;

    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.Write("Input positive integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

int s = CountNumber(b);
Console.WriteLine($"Num elements from {b} is {s}");
*/

// Задача №2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Sum(int a)
{
    int sum = 1;

    for(int current = 1; current <= a; current++)
    {
        sum *= current;
    }
    return sum;
}

Console.Write("Input positive integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

int s = Sum(b);
Console.WriteLine($"Sum of elements from {b} is {s}");
*/
//я правильно понимаю, вот эти два метода, которые мы сейчас разобрали, чтобы решить последние семинарские задачи, нужны оба метода? Через int метод мы, просто говоря, вводим, а 
//через войдовский метод выводим?
// Задача №4. Напишите программу, которая выводит массив из m элементов, 
// заполненный нулями и единицами в случайном порядке.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input  number: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/