int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int EvenNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, 100, 1000);
ShowArray(myArray);
Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbersCount(myArray)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int OddPositionsSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна: {OddPositionsSum(myArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] CreateDoubleArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }

    return array;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");

    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] intArray = CreateRandomArray(n, min, max);
double[] doubleArray = CreateDoubleArray(n);

double[] myArray = new double[n];
for (int i = 0; i < n; i++)
{
    myArray[i] = Convert.ToDouble(intArray[i]) + doubleArray[i];
}
ShowDoubleArray(myArray);

double MinElementOfArray(double[] array)
{
    double min = myArray[0];
    for (int i = 0; i < n; i++)
    {
        if (myArray[i] < min)
            min = myArray[i];
    }
    return min;
}

double MaxElementOfArray(double[] array)
{
    double max = myArray[0];
    for (int i = 0; i < n; i++)
    {
        if (myArray[i] > max)
            max = myArray[i];
    }
    return max;
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {Math.Round(MaxElementOfArray(myArray) - MinElementOfArray(myArray), 2)}");