// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);
*/
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int GetSumOfDidits(int num)
{
    if(num != 0) return GetSumOfDidits(num / 10) + num % 10;
    else return 0;
}
Console.WriteLine(GetSumOfDidits(1234));

// f(1234) -> 4 + f(123)
// f(123) -> 3 + f(12)
// f(12) -> 2 + f(1)
// f(1) -> 1 + f(0)
// f(0) -> 0
*/

// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int M, int N)
{
    if(M > N)
    {
        Console.Write(M + " ");
        ShowNums(M - 1, N);
    } 
    
    else if (M < N)
    {
        Console.Write(N + " ");
        ShowNums(N - 1, M);
    }

    else Console.Write(N + " "); 
    
}
ShowNums(7, 3);
*/
// Задача 2. Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В.
/*
double Method(double A, double B)
{
    if(B > 0) return A * Method(A, B - 1);
    else if (B < 0) return 1 / A * Method(A, B + 1);
    else return 1;
}

Console.WriteLine(Method(2, -3));
*/