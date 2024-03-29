﻿/*дан текст. в тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" - маленькими "с".

— Я думаю, — сказал князь, улыбаясь, — что,
ежели бы вас послали вместо нашего милого
Винценгероде, вы бы взяли приступом согласие
прусского короля. Вы так красноречивы. Вы
дадите мне чаю?*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы"
            + "дадите мне чаю?";

string Rep(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for( int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Rep(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Rep(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Rep(newText, 'С', 'с');
Console.WriteLine(newText);

