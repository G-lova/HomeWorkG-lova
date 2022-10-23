//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool NumPalindrome(int num)
{
    bool result = false;
    int i = 10;
    int count = 1;
    while (num >= i)
    {
        i = i * 10;
        count = count + 1;
    }
    int middle = 0;
    while (middle < count / 2)
    {
        int a = count - middle;
        int b = middle + 1;
        int c = count - b;
        int homeSign = num % Convert.ToInt32(Math.Pow(10,a)) / Convert.ToInt32(Math.Pow(10,c));
        int endSign = num % Convert.ToInt32(Math.Pow(10,b)) / Convert.ToInt32(Math.Pow(10,middle));
        if (homeSign == endSign)
        {
            result = true;
            middle = middle + 1;
        }
        else result = false;
        break;
    }  
    return result;
}


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumPalindrome(number));
*/

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance3d (double xa, double xb, double ya, double yb, double za, double zb)
{
    double sqrX = (xb - xa) * (xb - xa);
    double sqrY = (yb - ya) * (yb - ya);
    double sqrZ = (zb - za) * (zb - za);
    double distance = Math.Sqrt(sqrX + sqrY + sqrZ);
    return distance;
}

Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Distance3d(x1,x2,y1,y2,z1,z2);
Console.WriteLine($"Расстояние между двумя пространственными точками: {result}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeTable(int number)
{
    int i = 1;
    int cube = 0;
    while (i <= number)
    {
        cube = i * i * i;
        Console.Write(cube + " ");
        i++; 
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

CubeTable(num);