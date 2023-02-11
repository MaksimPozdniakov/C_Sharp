// Вводная часть
/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of Colums ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача №1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of Colums ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

void Show2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
// Задача №2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of Colums ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Kvadrat(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
        {
           array[i,j] = array[i,j] * array[i,j];
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine();

Kvadrat(myArray);
Show2dArray(myArray);
*/
// Задача №3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of Colums ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);  
        }
    }
    return array;
}

void Show2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int SumDiagArray(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        { 
            if(i == j)
                sum = sum + array[i,j];
        }
    }
    return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine();

Console.WriteLine($"Result = {SumDiagArray(myArray)}");
*/