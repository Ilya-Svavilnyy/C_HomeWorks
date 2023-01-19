// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountOfEven(int[] myArray2)
{
    int Count = 0;

    for (int i = 0; i < myArray2.Length; i++)
        if (myArray2[i] % 2 == 0)
        {
            Count = Count + 1;
        }
        return Count;
}

int[] myArray = new int[5];
myArray = CreateRandomArray(5, 100, 999);
ShowArray(myArray);
Console.WriteLine("Количество четных чисел массива " + CountOfEven(myArray));
*/          

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
/*
void CreateRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Input size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateRandomArray(numbers);
Console.WriteLine("Array: ");
ShowArray(numbers);
int sum = 0;

for (int z = 1; z < numbers.Length; z+=2)
{
    sum = sum + numbers[z];
}
Console.WriteLine($"Sum of negative indexes = {sum}");
*/
//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
 double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
    }
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}
double FindDif(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    double result = Math.Round(max - min, 2);
    return result;
}
Console.WriteLine("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max Value: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] array = CreateRandomDoubleArray(length, min, max);
ShowArray(array);
Console.WriteLine("Different min and max Value = " + FindDif(array)); 
*/