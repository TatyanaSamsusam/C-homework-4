/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine($"Введи 2 числа, и я возведу первое число в степень второго: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

double stepen = Math.Pow(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} это {stepen}");

