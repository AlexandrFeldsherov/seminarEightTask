/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int[,] NewMatrixArrRand(int a, int b)//создает массив заполнненный псевдослучайными вещественными числами числами в интервале от 'a' до 'b'
{
    Random rnd = new Random();
    int line = rnd.Next(4, 4); //случайная размерность строк массива
    int column = rnd.Next(4, 4); //случайная размерность сстолбцов массива
    int[,] newArr = new int[line, column];

    for (int i = 0; i < line; i++)
    {
        for (int ind = 0; ind < column; ind++)
        {
            int value = rnd.Next(a, b);
            newArr[i, ind] = value;
        }
    }
    return newArr;
}

void MinSummLines(int[,] array)
{
    int summLines = 0;
    int[] arrayNew = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summLines = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summLines = summLines + array[i, j];
        }
        arrayNew[i] = summLines;
    }
    int outputLines = ArrayIndexMinValue(arrayNew);
    Console.WriteLine($" Номер строки с наименьшей суммой элементов: {outputLines + 1} строка");
}
int ArrayIndexMinValue(int[] array)
{
    int minIndex = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    //PrintArray(array); для проверки суммы строк
    return minIndex;
}

void MatrixPrintArray(int[,] array)// печать двумерного массива int, в виде таблицы
{

    for (int ind = 0; ind < array.GetLength(0); ind++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            if (i == array.GetLength(1) - 1) Console.WriteLine($" {array[ind, i],3}");
            else Console.Write($"{array[ind, i],4}");
        }

    }
}
void PrintArray(int[] array)// печать  массива int
{

    for (int ind = 0; ind < array.Length; ind++)
    {
        Console.Write($"{array[ind]}, ");
    }
    Console.WriteLine();
}
Console.Clear();
int[,] array = NewMatrixArrRand(1, 10);
Console.WriteLine();
MatrixPrintArray(array);
Console.WriteLine();
MinSummLines(array);