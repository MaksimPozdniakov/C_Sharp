// Задача №1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] NewArray(int size) // метод по созданию массива. Вводить будем вручную каждый эллемент массива. 
{
    int[] myArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} elements array ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return myArray;
}

void ShowOurArray (int[] myArray) // Метод, который помогает выводить наш массив в терминал
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray() // метод по созданию массива. Массив генерируется рандомно. 
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value:  ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    int[] myArray = new int[size];

    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(min, max + 1);
    }
    return myArray;
}

int[] myArray = CreateRandomArray();
ShowOurArray(myArray);
*/

int[] CreateRandomArray() // метод по созданию массива. Массив генерируется рандомно. 
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value:  ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    int[] myArray = new int[size];

    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(min, max + 1);
    }
    return myArray;
}

void ShowOurArray (int[] myArray) // Метод, который помогает выводить наш массив в терминал
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}

// Первый вариант записи
/*
void ReverseArray (int[] myArray) 
{
    for (int i = 0; i < myArray.Length / 2; i++) 
    {
        int temp = myArray[i];
        myArray[i] = myArray[myArray.Length - 1 - i];
        myArray[myArray.Length - 1 - i] = temp;
    }
    Console.WriteLine();
}
*/
// Второй вариант записи

void ReverseArray (int[] myArray) 
{
    for (int i = 0, last = myArray.Length - 1; i < last; i++, last--) 
    {
        int temp = myArray[i];
        myArray[i] = myArray[last];
        myArray[last] = temp;
    }
}

int[] myArray = CreateRandomArray();
ShowOurArray(myArray);

ReverseArray(myArray);
ShowOurArray(myArray);


// Задача №2. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
/*
bool IsTiangle(int a, int b, int c)
{
    if (a > b + c && b > a + c && c > a + b) // почему такое условие??? 
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool res = IsTiangle(3,5,7);
Console.WriteLine(res);
*/
// Задача №3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int [] CopyArray(int[] myArray)
{
    int[] newArray = new int [myArray.Length];
    for (int i = 0; i < myArray.Length; i++)
    {
        newArray[i] = myArray[i];
    }
    return newArray;
}

int[] myArray = NewArray();
ShowOurArray(myArray);
int[] copiedArray = CopyArray(myArray);
ShowOurArray(myArray);
ShowOurArray(copiedArray);
*/
// Задача №4. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibonacci(int n, int a, int b)
{
    int[] Fib = new int[n];
    Fib[0] = a;
    Fib[1] = b;
    for(int i = 2; i < n; i++)
    {
        Fib[i] = Fib[i-1] + Fib[i-2];
    }
    return Fib;
}

int[] fibonacci = Fibonacci(6, 0, 1);
ShowOurArray(fibonacci);
*/