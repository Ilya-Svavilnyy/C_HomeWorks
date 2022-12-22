// Задача 1. Напишите программу, которая по задонному номеру четверти, показывает диапозон возможных координат точек в этой четверти( х и у).
/*
void GetDiapazone(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant ==3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/
// Задача 2. Напишите программу, которая принимает на вход координаты точки (Х и У), причем Х не равен 0 и У не равен 0 и выдает номер четверти плоскости, в которой находится эта точка.
/*
int GetQuadrant(int x, int y)
{
    int quadrant = -1;
    if(x > 0 && y > 0) quadrant = 1;
    else if(x < 0 && y > 0) quadrant = 2;
    else if(x < 0 && y < 0) quadrant = 3;
    else if(x > 0 && y < 0) quadrant = 4;
    return quadrant;
}

Console.Write("Введите координаты x и y: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (GetQuadrant(x,y) == -1) Console.WriteLine("Некорректный ввод!");
else Console.WriteLine("Номер четверти:  " + GetQuadrant(x, y));
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдает квадраты чисел от 1 до N.
/*
void Quad(int n)
{
    int count = 1;
    Console.WriteLine("Квадраты чисел: ");
    while(count < n + 1)
    {
        Console.Write(count * count + " ");
        count ++;
    }
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Quad(n);
*/

// Задача 4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2Д пронстранстве.
/*
double Distance(double x1, double y1,
                double x2, double y2)
{
    double res1 = Math.Pow(x2 - x1, 2);
    double res2 = Math.Pow(y2 - y1, 2);
    double result = Math.Sqrt(res1 + res2);
    return result;
}
Console.Write("Введите координаты первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Distance(x1, y1, x2, y2));
*/