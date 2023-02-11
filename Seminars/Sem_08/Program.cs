// Задача №1. Задайте двумерный массив. Напишите программу, которая 
//заменяет строки на столбцы. В случае, если это невозможно, программа 
//должна вывести сообщение для пользователя. 
//Как бы проверяем матрицу на квадратность.
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

void ChangeArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
    else
    {
        Console.Write("Это невозможно ");
    }  
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

ChangeArray(myArray);

Show2dArray(myArray);
*/

//Задача №2. Задайте двумерный массив. Напишите программу, которая 
//поменяет местами первую и последнюю строку массива.
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

void ChengeArray(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

ChengeArray(newArray);

Show2dArray(newArray);
*/

//Задача №3. Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
/* перерешать и вообще понять что это такое???????????
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
    }
}

int[,] Delete(int[,] array)
{
    int iMin = 0;
    int jMin = 0;
    int min = array[0,0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                iMin = i;
                jMin = j;
            }
        }
    }
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1,];
    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == iMin && j == jMin)
            {

            }
        }
}
*/