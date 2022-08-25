//Напишите программу, которая дает 3 попытки для того, чтобы отгадать цифру 4
//(если все попытки будут потрачены, а цифра не будет отгадана, то на экране должна вывестись фраза "Ты не угадал...").

int count = 0;
bool flag = false;

int NumberFromUser (string textToUser)
{
    Console.WriteLine(textToUser);
    return Convert.ToInt32(Console.ReadLine());
}

while (count < 3 && !flag)
{
    if (NumberFromUser("Попытка " + count++) == 4)
    { 
        flag = true;
        Console.WriteLine("Верно");
    }
    
}

if(!flag) Console.WriteLine("Ты не угадал...");
