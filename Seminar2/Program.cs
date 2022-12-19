// Задача написать програаму по поиску трехзначных чисел и удаления цифры которая находится посередине.
/*
int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNumber = new Random().Next(100, 1000);
Console.WriteLine("Current random three-digit number is " + randNumber);

int newNumber = CutNumber(randNumber);
Console.WriteLine("New version of number is " + newNumber);
*/

// Задача 1. Напишите программу, которая выводит случайное число из отрезка 10,99 и показывает наибольшую цифру числа.
/*
int IsMax(int number)
{
    int num1 = number / 10;
    int num2 = number % 10;
    
    if(num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

int number = new Random().Next(10, 100);
int numMax = IsMax(number);
Console.WriteLine(number);
Console.WriteLine(numMax);
*/

// Задача 2. Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому.
/*
bool IsQuad(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"number is {IsQuad(num1, num2)}");
    

 }*/

 // Задача 3. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно квадратом другого.
/*
 bool IsQuad(int num1, int num2)
{
    if(num1 * num1 == num2 || num2 * num2 == num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(IsQuad(num1, num2));
*/