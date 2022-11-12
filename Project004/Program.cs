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

int OddPositionsSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимаьного элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна: {OddPositionsSum(myArray)}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
