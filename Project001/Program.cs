//ДЗ 1
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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