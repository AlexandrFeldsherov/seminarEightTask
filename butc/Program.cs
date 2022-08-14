int sizeArray = 5;
int[] array = new int[sizeArray];
Console.WriteLine("Введите элемент массива : ");
for (int i = 0; i < sizeArray; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < sizeArray - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < sizeArray; j++)
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