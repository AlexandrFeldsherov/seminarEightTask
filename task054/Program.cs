/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
int[,] NewMatrixArrRand(int a, int b)//создает массив заполнненный псевдослучайными вещественными числами числами в интервале от 'a' до 'b'
{
    Random rnd = new Random();
    int line = rnd.Next(3, 5); //случайная размерность строк массива
    int column = rnd.Next(3, 5); //случайная размерность сстолбцов массива
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
int[,] ArraySortingLines(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {

            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int max = 0;
                    max = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = max;
                }
            }
        }
    }
    return array;
}
void MatrixPrintArray(int[,] array)// печать двумерного массива int, в виде таблицы
{

    for (int ind = 0; ind < array.GetLength(0); ind++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            if (i == array.GetLength(1) - 1) Console.WriteLine($" {array[ind, i],6}");
            else Console.Write($"{array[ind, i],6}");
        }

    }
}
Console.Clear();
int[,] array = NewMatrixArrRand(1, 15);
Console.WriteLine();
MatrixPrintArray(array);
Console.WriteLine();
array = ArraySortingLines(array);
Console.WriteLine();
MatrixPrintArray(array);

