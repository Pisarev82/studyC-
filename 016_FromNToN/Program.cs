// Пользователь вводит число N. Выведите все числа от -N до N

int number = InputIn("Введите целое число");

if (number > 0) PrintFromNegatiNToPositivN(number);
else PrintFromNegatiNToPositivN(-number);

void PrintFromNegatiNToPositivN (int num)
{
    
    int negativNum = - num;
    while (negativNum <= num) 
    {
        Console.WriteLine($"{negativNum} ");
        negativNum++;
    }
} 

int InputIn(string messengeForUser)
{
    Console.WriteLine(messengeForUser);
    return Convert.ToInt32(Console.ReadLine());
}