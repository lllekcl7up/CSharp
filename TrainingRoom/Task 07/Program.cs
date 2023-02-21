//Задача: необходимо ввести имя, Машу поприветствовать особым образом.

Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "маша")
{
    Console.WriteLine("ВАУ - Маша, ты пришла!");
}
else
{
    Console.Write($"Привет, ");
    Console.WriteLine(username);
}