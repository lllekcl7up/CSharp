
Console.Write($"Введите элементы массива через пробел: ");
string stringFromPerson = Console.ReadLine()!;
Console.WriteLine();

string[] CreateStringToArray (string str)
{
    string [] arrayString = str.Split(' ');
    return arrayString;
}

string[] SecondArray(string[] array, int maxLenght)
{
    int index = default;
    int size = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLenght) size++;
    }
    string[] arrayTwo = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLenght)
            arrayTwo[index++] = array[i];

    }
    return arrayTwo;
}

void PrintArray (string [] array )
{
     Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else 
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string [] arrayOne = CreateStringToArray(stringFromPerson);
string [] arrayTwo = SecondArray(arrayOne,3);// тут мы можем определить длину фильтрации значений

Console.Write("Исходный массив: ");
PrintArray(arrayOne);
Console.Write("Новый массив: ");
PrintArray(arrayTwo);



