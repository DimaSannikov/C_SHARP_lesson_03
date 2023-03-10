// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого "
            + "Винценгероде, вы бы взяли приступом согласие "
            + "прусского короля. Вы так красноречивы. Вы "
            + "дадите мне чаю?";

string replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;

    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = replace(newText, 'C', 'c');
Console.WriteLine(newText);