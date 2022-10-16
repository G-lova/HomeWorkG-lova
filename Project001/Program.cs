//ДЗ 1
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} больше, чем {secondNumber}");
}
else
{
    if (secondNumber > firstNumber)
    {
        Console.WriteLine($"{secondNumber} больше, чем {firstNumber}");
    }
    else
    {
        Console.WriteLine("Эти числа равны");
    }
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max)
{
    max = secondNumber;
}
if (thirdNumber > max)
{
    max = thirdNumber;
}
Console.WriteLine($"Максимальное число {max}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int even = number % 2;
if (even == 0)
{
Console.WriteLine($"Число {number} является четным");
}
else
{
    Console.WriteLine($"Число {number} является НЕчетным");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите положительное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 2)
{
    int count = 2;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
else
{
    Console.WriteLine($"В интервале от 1 до {number} нет четных чисел");
}