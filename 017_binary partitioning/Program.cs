// Последовательное заполнение бинарного массива.


int[] binarArray = new int[5];
// int targetCount = 0;
int count = 1;
int i = 0;
int j = i;
while (i < binarArray.Length)
{
   if (binarArray[i] == 0 ) 
    {
        binarArray[i] = 1;
        j = i-1;
        while (j >= 0)
        {
            binarArray[j] = 0;
            j--;
        }
        
        PrintArray(binarArray);
        Console.WriteLine();
        count++;
        i = 0;
    }  
    else i++;    
}

Console.WriteLine();
Console.WriteLine(count);

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


