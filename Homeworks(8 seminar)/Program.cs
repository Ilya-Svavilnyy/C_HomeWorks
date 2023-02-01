// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убывванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2DArray()
{
    Console.Write("Inut a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Inut a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Inut a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Inut a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    return array;    
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowNewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
ShowNewArray(myArray);
Show2DArray(myArray);
*/
// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a msx possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            Console.WriteLine();
        }
    Console.WriteLine();
}
int MinSumInRow(int[,] array)
{
    int minSum = 0;
    int numRow = 0;
    for(int i = 0, j = 0; j < array.GetLength(1); j++) 
        minSum += array[i, j];
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if(sum < minSum) 
        {
            minSum = sum;
            numRow = i;
        }
    }
    return numRow + 1;
}
int[,] array = CreateRandom2dArray();
Show2dArray(array);
Console.WriteLine("Number of row with minimal sum of numbers: " + MinSumInRow(array));
*/
// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2DArray()
{
    Console.Write("Inut a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Inut a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Inut a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Inut a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    return array;    
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] Product(int[,] matrix1, int[,] matrix2)
{
    int[,] productMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for(int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for(int j = 0; j < matrix2.GetLength(0); j++)
        {
            productMatrix[i,j] = 0;
            for (int k = 0; k < matrix1.GetLength(0); k++)
                {
                    productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
        }
    }

    return productMatrix;
}

int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
int[,] matrix1 = myArray;
int[,] matrix2 = CreateRandom2DArray();
Show2DArray(matrix2);
int[,] numbersOfMat = Product(matrix1, matrix2);
Show2DArray(numbersOfMat);
*/
// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет выводить построчно массив, добавляя индексы каждого элемента.
/*
int[,,] Create3DRandomArray()
{
    Console.Write("Input a number of elements X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of elements Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of elements Z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
int[,,] newArray = Create3DRandomArray();
Show3DArray(newArray); 
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.