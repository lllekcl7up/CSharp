// ==== Работа с текстом
// Дан текст, в тексте нужно все проблемы заменить черточками, 
// маленькие буквы "к" заменить большими "К", 
// а большие "С" заменить маленькими "с".

// Ясна ли задача? 

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ужели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю ?";


// string s = " q w e r t y "
//              0 1 2 3 4 5 номерация символов на клавиатуре
// s[3] // r третий символ получается R

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)        result = result + $"{newValue}";
// если символ с №i равен старому значению    ТО в result положить НОВОЕ значение
        else result = result + $"{text[i]}";
// если совподений не обноружено в result добавить текущий символ который и был
    }
    return result;
}
string newText = Replace(text, ' ', '|');
// тут как раз мы просим метод менять старые значения на новые 
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);