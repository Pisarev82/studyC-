// Выведети на экрон все возможные варианты распределения N числа игроков на 2 команды
// в одной команде может быть любое колличество ингроков от 0 до N

Console.WriteLine("Введите колличество игроков: ");
int userNumberInput = Convert.ToInt32(Console.ReadLine());
if (userNumberInput > 0)
{
int[] gamersArray = CrateGamersArray(userNumberInput);

int[] binarArray = new int[userNumberInput];
// int targetCount = 0;
int count = 1;
Console.WriteLine("0 1 2 3 4 <-> ");
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
        
        PrintTeamFromArray(gamersArray, binarArray, 0);
        Console.Write("<-> ");
        PrintTeamFromArray(gamersArray, binarArray, 1);
        Console.WriteLine();
        count++;
        i = 0;
    }  
    else i++;    
}

Console.WriteLine();
Console.WriteLine("Колличество вариантов: " + count);
}


void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintTeamFromArray (int[] array, int[] binarArrayForMethod, int team)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (binarArrayForMethod[i] == team) Console.Write($"{array[i]} ");
    }
}

int[] CrateGamersArray(int numberGamers)
{
    int[] array = new int[numberGamers];
    for (int i = 0; i < numberGamers; i++)
    {
        array[i] = i;
    }
    return array;
}
