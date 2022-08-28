// Перевод n-ичного числа в десятичную систему исчисления
// n может принимать значения от 2 до 9


string n = InputIn("Введите число от 2 до 9 для указания системы исчисления");
string number = InputIn("Введите число в указанной системе исчисления");


string InputIn (string invitationForUser)
{
    Console.WriteLine(invitationForUser);
    return Console.ReadLine();
}


double conversionToDecimal (string sisCalk, string numberIn)
{
    int numberOfDigits = numberIn.Length;
    int pov = numberOfDigits - 1;
    double sum = 0;
    int digit = 0;
    int sisCalkInt = Convert.ToInt32(sisCalk);
    for (int i = 0; i < numberOfDigits ; i++)
    {
        //Console.WriteLine(numberIn[i]);
        digit = Convert.ToInt32(Convert.ToString(numberIn[i]));
        if (digit < sisCalkInt ) sum = Math.Pow(sisCalkInt, pov) * digit + sum;
        Console.WriteLine($"{digit}*{sisCalkInt}^{pov} = {sum}" );
        pov--;
    }
    return sum;
}

Console.WriteLine($"Число {number} записанное в {n}",  
                "системе исчесления в десятичной составляет: {conversionToDecimal(n, number)}");
