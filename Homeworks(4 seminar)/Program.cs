// Задача 25: Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
/*
int GetPow(int a, int b)
{
    int mul = a;

    for(int i = 1; i < b; i++)
    {
        a = a * mul;
    }
    return a;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a pow number: ");
int b = Convert.ToInt32(Console.ReadLine());
int powResult = GetPow(a, b);
Console.WriteLine(powResult);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдает сумму цифр в числе:
/*
int GetSum(int num)
{
    int i = 0;

    while(num != 0)
    {
        int sum = num % 10;
        num = num /10;
        i = i + sum;
    }
    return i;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = GetSum(a);
Console.WriteLine(result);
*/
// Задача 29: Напишите программу, которая задает массив из m элементов и выводит их на экран.
/*
int[] NewArray (int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i} array elements: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] createArray = NewArray(m);
ShowArray(createArray);
*/