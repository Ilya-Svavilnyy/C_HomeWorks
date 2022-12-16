// Домашнее задание(по 1му семинару)

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if(num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(num1 > num2)
    max = num1;
else
    max = num2;
if(num2 > num3)
    max = num2;
else
    max = num3;
if(num1 > num3)
    max = num1;
else
    max = num3;

Console.Write(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на 2 без остатка).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int max = num % 2;

if(max==0)
    Console.WriteLine(num +  " Это число чётное!");
else
    Console.WriteLine(num +  " Это число нечётное!");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/