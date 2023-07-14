﻿// Домашнее задание
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//       m = 2, n = 3 -> A(m,n) = 9
//       m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int A(int n, int m)
{
    if (n == 0) return (m + 1);
    if (m == 0) return A(n - 1, 1);
    return A(n-1, A(n, m - 1));
}
Console.WriteLine($"A({m},{n}) = {A(m,n)}");