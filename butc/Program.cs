int[] NewArrayConsole(int[] array)
{
    Console.WriteLine("Введите элемент массива : ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ArraySortingChoice(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[min] > array[j])
            {
                min = j;
            }
        }
        int value = array[i];
        array[i] = array[min];
        array[min] = value;
    }
    Console.WriteLine(string.Join(", ", array));
}
Console.WriteLine("Введите кл-во элементов массива : ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];
array = NewArrayConsole(array);
ArraySortingChoice(array);