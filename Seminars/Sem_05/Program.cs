// Задача №1. Задайте массив из 5 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CreateArray(int size)
{
    int[] array = new int [size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} elements of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Cmplete!");
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOFNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumOFNegatives(myArray);
ShowArray(myArray);

Console.WriteLine("Sum of a negative elements is " + result);
*/

// Задача №2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//Что-то не получилось
/*
int[] CreateArray(int size)
{
    int[] array = new int [size];
    Console.WriteLine("Creating array: ");
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} elements of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Cmplete!");
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int newArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {    
        array[i] = (-1) * array[i];
        return array[i]; 
    }  
}

Console.Write(" ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = newArray(myArray);
ShowArray(myArray);

Console.WriteLine(result);
*/
// Задача №3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/* перерешать
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int [size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    Console.WriteLine(" ");
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
bool FindElements(int[] array, int find)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == find)
        {
            return true;
        } 
    }
    return false;
}
Console.Write("Input size array ");
int a = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;
Console.Write("Input number");
int find = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size, min, max);
ShowArray(myArray);
bool res = FindElements(myArray);
Console.WriteLine(res);
*/
// Задача №4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int [size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    Console.WriteLine(" ");
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int AmountElements(int[] array)
{
    int amount = 0;
    for(int i = 0; i< array)
}
*/