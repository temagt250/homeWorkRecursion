﻿// Домашнее задание
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Выполнить с помощью рекурсии.
//   M = 1; N = 5 -> "1, 2, 3, 4, 5"
//   M = 4; N = 8 -> "4, 5, 6, 7, 8"
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + ", " + PrintNumbers(start + 1, end);
}
Console.WriteLine($"числа в промежутке от {M} до {N}: '{PrintNumbers(M, N)}'");