// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
    if (numberOfDay<1 || numberOfDay>7) Console.WriteLine("Введите число от 1 до 7 заново");

    else
        {
    bool weekend = Weekend(numberOfDay);
    Console.WriteLine(weekend ? "Это выходной" : "Это не выходной");

    bool Weekend (int day)
    {
    return day==6 || day==7;
    }
        }