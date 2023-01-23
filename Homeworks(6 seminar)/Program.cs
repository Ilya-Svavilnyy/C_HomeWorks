// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void CountPositiveNumbers()
{
    Console.WriteLine("Input size of numbers: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input numbers {i + 1}: ");
        int numbers = Convert.ToInt32(Console.ReadLine());

        if(numbers > 0)
        {
            count++;
        }
    }
    Console.Write("Amount a positive numbers: " + count);
}
CountPositiveNumbers();
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void PointOnLines(double k1, double b1, double k2, double b2)
{
	double x = (b1 - b2) / (k2 - k1);
	double y = (k2 * b1 - k1 * b2) / (k2 - k1);

	if (k1 == k2)
    {
        Console.WriteLine("Impossible to find a point");
    }
	else
    {
        Console.WriteLine($"Point on line = {x}, {y}");
    }
}

Console.Write("Input the b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PointOnLines(k1, b1, k2, b2);
*/