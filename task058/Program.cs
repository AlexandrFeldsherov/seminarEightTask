/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] NewMatrixArrRand(int a, int b)//создает массив заполнненный псевдослучайными вещественными числами числами в интервале от 'a' до 'b'
{
    Random rnd = new Random();
    int line = rnd.Next(2, 2); //случайная размерность строк массива
    int column = rnd.Next(2, 2); //случайная размерность сстолбцов массива
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

void MatricesProduct(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] newArr = new int[arrayFirst.GetLength(0), arrayFirst.GetLength(0)];
    int sum = 0;
    int value = 0;
    if (arrayFirst.GetLength(1) != arraySecond.GetLength(0)) Console.WriteLine("Произведение матриц не существует.");
    else
    {
        for (int i = 0; i < arrayFirst.GetLength(0); i++)
        {
            for (int k = 0; k < arraySecond.GetLength(1); k++)
            {
                for (int j = 0; j < arrayFirst.GetLength(1); j++)
                {
                    sum = arrayFirst[i, j] * arraySecond[j, k];
                    value += sum;
                }
                newArr[i, k] = value;
                value = 0;
            }
        }
    }
    Console.WriteLine("Результирующая матрица будет:");
    MatrixPrintArray(newArr);
}

int[,] arrayFirst = NewMatrixArrRand(1, 10);
int[,] arraySecond = NewMatrixArrRand(1, 10);
MatrixPrintArray(arrayFirst);
Console.WriteLine("___________");
MatrixPrintArray(arraySecond);
Console.WriteLine();
MatricesProduct(arrayFirst, arraySecond);
