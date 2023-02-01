// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}

ShowNums(8);
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNumbers(int M, int N)
{
    if (M < N) return SumOfNumbers(M + 1, N) + M;
    else if (M == N) return M;
    else return -1;
}
Console.Write("Input value M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNumbers(M, N));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckFunction(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0 && M != 0)
        return AckFunction(M - 1, 1);
    else
        return AckFunction(M - 1, AckFunction(M, N - 1));
}

Console.Write("Input value M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckFunction(m, n));
*/