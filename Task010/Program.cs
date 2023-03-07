// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int middleDigit = MiddleDigit (number);
Console.WriteLine ($"cредняя цифра числа -> {middleDigit}" );

int MiddleDigit(int num)
{
    return ((num/10)%10);
}
