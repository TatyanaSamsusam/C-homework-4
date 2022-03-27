/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int SumOfDigits (int number)
{
int result = 0;

while (number > 0)
{
    int DigitInNumber = number %10;
    result = result + DigitInNumber;
    number = number /10;
}
return result;
}

Console.WriteLine($"Введи число, и я посчитаю сумму цифр в нем: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDigits(num);

Console.WriteLine($"Сумма всех цифр в чиле {num} равна {sum}");