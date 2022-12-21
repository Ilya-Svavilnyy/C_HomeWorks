// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecNumber(int number)
{
    int third = number % 100;
    int first = third / 10;

    int result = first;
    return result;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int min = 100;
int max = 1000;

if(number < max && number > min)
{
    int NewNumber = SecNumber(number);
    Console.WriteLine("Вторая цифра: " + NewNumber);
    
}
else
{
    Console.WriteLine("Это число не трёхзначное!");
}
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThiNumber(int number)
{
    int count = number / 100;
    if(count == 0)
    {
            return -1;
    }
    int num3 = 1;
    while(count > 0)
    {
        count = count / 10;
        num3 = num3 * 10;
    }
    return number % num3 / (num3 / 10);
}

Console.Write("Введите число: ");
int randomNumber = Convert.ToInt32(Console.ReadLine());
 
if(randomNumber < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    int ThirdNumber = ThiNumber(randomNumber);
    Console.WriteLine("Третья цифра:   "  +  ThirdNumber );
}
*/

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int day)
{
if(day == 6 || day == 7)
{
    return true;
}
else
{
    return false;
}
}
Console.Write("Введите число - день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(Weekend(day))
{
    Console.WriteLine("Выходной!!!");
}
else
{
    Console.WriteLine("Рабочий день!");
}
