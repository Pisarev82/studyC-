﻿// На столе лежит 2021 конфет. 
// Играет 2 игрока. За 1 ход игрок может забрать 1-28 конфет.
// Игрок забравший последнюю конфету - виигрывает и отбирает у другого игрока кофеты.
// за Второго игрока играет компьютер. Написание безпроигрошной для компьютера стратегии.

int candis = 10;
int step = 3;

int InputNumber (string text)
{
Console.WriteLine(text);
int userNumberInput = Convert.ToInt32(Console.ReadLine());
if (userNumberInput <= 28 && userNumberInput > 0) return userNumberInput;
else 
{
    Console.WriteLine("Не мухлюйте. Вам придется забрать 1 кофету");
    return 1; 
}
}
bool turnFirstGamer = true;
while (candis > 0)
{
    if (turnFirstGamer) 
    {
        candis = candis - InputNumber($"Осталось {candis} конфет. Ходит первый игрок. Сколько конфет забираете? :  ");
        turnFirstGamer = !turnFirstGamer;
    }
    else
     {
        Console.WriteLine($"Осталось {candis} конфет. Ходит второй игрок. Сколько конфет забираете? : ");
        candis = candis - TurnOfIi (step, candis);
        turnFirstGamer = !turnFirstGamer;
    }
}

if (!turnFirstGamer) Console.WriteLine("Выиграл первый игрок");
else Console.WriteLine("Выиграл второй игрок");

int TurnOfIi (int remainsInMethod, int stepInMethod)
{
    int result = 1;

    if (stepInMethod <= remainsInMethod ) result = remainsInMethod;
    else 
    {
        result = remainsInMethod % (stepInMethod + 1);
        
    }
    Console.WriteLine(result);
    return result;
}