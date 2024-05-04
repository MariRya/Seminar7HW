﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
Console.WriteLine("Введите значение М: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers (number1, number2);
void PrintNaturalNumbers(int number1, int number2)
{
if(number2 >= number1)
{  
PrintNaturalNumbers(number1, number2 - 1);
Console.Write($"{number2} ");
}
}