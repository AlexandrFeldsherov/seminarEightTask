/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/


int Recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Recursion(m - 1, 1);
    }
    else
    {
        return Recursion(m - 1, Recursion(m, n - 1));
    }
}

Console.Clear();
Console.Write("Введите положительное число m : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число n : ");
int n = int.Parse(Console.ReadLine());
Console.Write($"m = {m}, n = {n} -> A({m},{n}) = {Recursion(m, n)}"); // вызов рекурсивной функции
