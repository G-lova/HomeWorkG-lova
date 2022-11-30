/*
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
*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
void SortByDecending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            int jMax = j-1;
            for (int jCount = j; jCount < array.GetLength(1); jCount++)
                if (array[i, jCount] > array[i, jMax])
                    jMax = jCount;
            int temp = array[i, j - 1];
            array[i, j - 1] = array[i, jMax];
            array[i, jMax] = temp;
        }
    }
}


SortByDecending(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int MinElementPosition(int[] array)
{
    int iMin = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < array[iMin])
            iMin = i;
    return iMin;
}

int MinSumRow(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sumArray[i] += array[i, j];
    return MinElementPosition(sumArray);
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSumRow(myArray) + 1}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] MatrixProductArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    int i = 0;
    int j = 0;
    int i1 = 0;
    int i2 = 0;
    int j1 = 0;
    int j2 = 0;
    for (i = 0, i1 = 0; i < resultArray.GetLength(0); i++, i1++)
        for (j = 0, j2 = 0; j < resultArray.GetLength(1); j++, j2++)
        {
            resultArray[i, j] = 0;
            for (j1 = 0, i2 = 0; j1 < array1.GetLength(1); j1++, i2++)
                resultArray[i, j] += (array1[i1, j1] * array2[i2, j2]);

        }
    return resultArray;
}

Console.Write("Введите количество столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального элемента второй матрицы: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального элемента второй матрицы: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray2 = CreateRandom2dArray(n, n2, min2, max2);
Show2dArray(myArray2);

Console.WriteLine("Произведение двух матриц равно:");
Show2dArray(MatrixProductArray(myArray, myArray2));
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
bool ContainNumber(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, j, k] == number)
                    return true;
    return false;
}

int[,,] CreateRandom3dArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                int temp = new Random().Next(10, 100);
                if (ContainNumber(array, temp) == false)
                    array[i, j, k] = temp;
                else
                    k--;
            }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

Console.Write("Введите длину матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(l, m, n);
Show3dArray(myArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiral2dArray(int size)
{
    int[,] array = new int[size, size];
    int i = 0;
    int j = 0;
    int value = 1;
    int count = 0;
    while (value <= size * size)
    {
        for (j = count; j < size - count; j++)
        {
            array[i, j] = value;
            value++;
        }
        j--;
        for (i = count + 1; i < size - count; i++)
        {
            array[i, j] = value;
            value++;
        }
        i--;
        for (j = size - (count + 2); j > (count - 1); j--)
        {
            array[i, j] = value;
            value++;
        }
        j++;
        count++;
        for (i = size - (count + 1); i > (count - 1); i--)
        {
            array[i, j] = value;
            value++;
        }
        i++;
    }
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

Console.Write("Введите количество строк/столбцов квадратной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiral2dArray(n);
Show2dArray(myArray);

