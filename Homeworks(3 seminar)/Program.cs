// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool IsPalindrome(int number)
 {
     int cal;
     int num = number;
     int rev = 0;

     while(number > 0)
     {
         cal = number % 10;
         rev = rev * 10 + cal;
         number = number / 10;
     }
     if(num == rev) return true;
     return false;
 }
 Console.Write("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 if(IsPalindrome(number)) Console.WriteLine("Да, является палиндромом!");
 else Console.WriteLine("Нет, не является палиндромом!");
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1,
                double x2, double y2, double z2)
{
    double res1 = Math.Pow(x2 - x1, 2);
    double res2 = Math.Pow(y2 - y1, 2);
    double res3 = Math.Pow(z2 - z1, 2);
    double result = Math.Sqrt(res1 + res2 + res3);
    return result;
}
Console.Write("Введите координаты первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Distance(x1, y1, z1, x2, y2, z2));
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Qube(int n)
{
    int count = 1;
    Console.WriteLine("Числа в кубе: ");
    while(count < n + 1)
    {
        Console.Write(count * count * count + " ");
        count ++;
    }
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Qube(n);
*/