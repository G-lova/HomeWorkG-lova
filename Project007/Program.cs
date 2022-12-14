int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateDouble2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().NextDouble();
    return array;
}

void ShowDouble2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] int2dArray = CreateRandom2dArray(m, n, min, max);
double[,] double2dArray = CreateDouble2dArray(m, n);

double[,] myArray = new double[m, n];
for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
        myArray[i, j] = Convert.ToDouble(int2dArray[i, j]) + double2dArray[i, j];

ShowDouble2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int ArrayElementValue(int[,] array2d, int rowPosition, int columnPosition)
{
    Console.Write("Введите номер строки: ");
    rowPosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    columnPosition = Convert.ToInt32(Console.ReadLine());
    while (rowPosition >= array2d.GetLength(0) || columnPosition >= array2d.GetLength(1))
    {
        Console.WriteLine("Такого элемента не существует");
        Console.WriteLine();
        Console.Write("Введите номер строки: ");
        rowPosition = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца: ");
        columnPosition = Convert.ToInt32(Console.ReadLine());
    }
       
    return array2d[rowPosition, columnPosition];
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine("Значение элемента: " + ArrayElementValue(myArray, m, n));


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

double[] ColumnsArithmeticMean(int[,] array)
{
    double[] arithmeticMeanArray = new double[array.GetLength(1)];
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arithmeticMeanArray[j] = sum / i;
    }
    return arithmeticMeanArray;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");

    Console.WriteLine();
}

Console.WriteLine("Средние арифметическое элементов по столбцам:");
ShowDoubleArray(ColumnsArithmeticMean(myArray));
*/