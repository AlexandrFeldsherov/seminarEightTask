/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int NaturalNumber(int m, int n)
{
    if (n > m) n += NaturalNumber(m, n - 1);
    return n;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = NaturalNumber(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sum}");