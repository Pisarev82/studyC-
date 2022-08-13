﻿// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого"
              +"Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы"
              +"дадите мне чаю?";

string Change_symbol (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Change_symbol(text, ' ', '|');
System.Console.WriteLine(newText);
newText = Change_symbol(newText, 'к', 'К');
System.Console.WriteLine(newText);
newText = Change_symbol(newText, 'С', 'с');
System.Console.WriteLine(newText);