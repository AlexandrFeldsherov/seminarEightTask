/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] NewMatrixArrRandThree(int line, int column, int depth)
{

    Random rnd = new Random();
    int[,,] newArr = new int[line, column, depth];

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int value = rnd.Next(10, 100);
                while (ArrayRepeatValuesReplace(newArr, value))
                {
                    value = rnd.Next(10, 100);
                }
                newArr[i, j, k] = value;
            }
        }
    }
    return newArr;
}
bool ArrayRepeatValuesReplace(int[,,] array, int value)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value) return true;
            }
        }
    }
    return false;
}
void PrintMatrixArrayThree(int[,,] array)// печать двумерного массива int в виде таблицы
{

    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k],1}({i},{j},{k})   ");
            }
        }
    }
}
int[,,] array = NewMatrixArrRandThree(2, 2, 2);
PrintMatrixArrayThree(array);

