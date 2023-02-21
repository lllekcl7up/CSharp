//Ввести любой символ и указать предыдущий и последующий символы. 

Console.WriteLine("Введите любой символ: ");
char x = Console.ReadLine()![0];
Console.WriteLine("Предыдущий символ: {0}", (char)(x-1));
Console.WriteLine("Следующий символ: {0}", (char)(x+1));