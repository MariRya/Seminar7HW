// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

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