// 

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray (int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void OrderingArray (int[] array)
{
    int length = array.Length;
    
    for (int i = 0; i < length - 1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
Console.WriteLine();
OrderingArray(arr);
PrintArray(arr);