// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

   if(number<100) Console.WriteLine("Третьей цифры нет");

   else 
   {    
   int thirdDigit =ThirdDigit(number);
   Console.WriteLine($"Третья цифра числа {number} это - {thirdDigit}");

    int ThirdDigit (int num)
    {
        while(num>=999)
        {
            num=num/10;
        }
    return (num%10);
    }
   }





