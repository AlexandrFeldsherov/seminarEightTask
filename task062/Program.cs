/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

bool OutPosition(int[,] arr, int line, int column)//есть ли индекс в массиве
{
    return (line < arr.GetLength(0)
                     && column < arr.GetLength(1)
                        && line >= 0
                            && column >= 0);
}

int[,] ArrayСompletionSnake(int[,] array, int i, int j) /*заполнение пустого int[,] змейкой с 
определенной точки принадлежащей массиву*/
{
    int lastValueArray = array[i, j] + 1;
    if (array[i, j] == 0)
    {
        array[i, j] += 1;
    }
    else if (OutPosition(array, i, j + 1) && array[i, j + 1] == 0) j = j + 1;
    else if (OutPosition(array, i + 1, j) && array[i + 1, j] == 0) i = i + 1;
    else if (OutPosition(array, i, j - 1) && array[i, j - 1] == 0) j = j - 1;
    else if (OutPosition(array, i - 1, j) && array[i - 1, j] == 0) i = i - 1;
    else return array;
    array[i, j] = lastValueArray;
    array = ArrayСompletionSnake(array, i, j);
    return array;
}
int[,] ArrayСompletionSpiral(int[,] array, int i, int j) /*заполнение пустого int[,] спираль с 
определенной точки принадлежащей массиву*/
{
    if (array[i, j] == 0)
    {
        if (OutPosition(array, i, j - 1)) array[i, j] += array[i, j - 1] + 1;
        else array[i, j] += 1;
    }
    else return array;
    while (OutPosition(array, i, j + 1) && array[i, j + 1] == 0)
    {
        int lastValueArray = array[i, j] + 1;
        j++;
        array[i, j] = lastValueArray;
    }
    while (OutPosition(array, i + 1, j) && array[i + 1, j] == 0)
    {
        int lastValueArray = array[i, j] + 1;
        i++;
        array[i, j] = lastValueArray;
    }
    while (OutPosition(array, i, j - 1) && array[i, j - 1] == 0)
    {
        int lastValueArray = array[i, j] + 1;
        j--;
        array[i, j] = lastValueArray;
    }
    while (OutPosition(array, i - 1, j) && array[i - 1, j] == 0)
    {
        int lastValueArray = array[i, j] + 1;
        i--;
        array[i, j] = lastValueArray;
    }
    j++;
    array = ArrayСompletionSpiral(array, i, j);
    return array;
}


void PrintMatrixArray(int[,] array)// печать двумерного массива int в виде таблицы
{

    for (int ind = 0; ind < array.GetLength(0); ind++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            if (i == array.GetLength(1) - 1) Console.WriteLine($" {array[ind, i],2}");
            else Console.Write($"{array[ind, i],3}");
        }

    }
}
int[,] array = new int[4, 4];
array = ArrayСompletionSpiral(array, 0, 0);
//array = ArrayСompletionSnake(array, 0, 0);
PrintMatrixArray(array);
