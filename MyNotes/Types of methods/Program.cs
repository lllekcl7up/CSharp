// Виды методов 

// Вид 1 

void Method1()
{
    Console.WriteLine("Автор...");
}
// Method1();

// Вид 2 

void Method2(string msg)
{
  Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method2a(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
      Console.WriteLine(msg);
      i++;
    }
}
// Method2a(msg: "Текст", count: 4);// тут вставляем цифру 4 чтобы увидеть слово ТЕКСТ 4 раза 
// Method2a("БЕЗ MSG и COUNT", 4); // можно так вызывать метод 
// Method2a(count:4 , msg: "новый текст");// можно таким образом ...

// Вид 3 //Возвратный метод возвращающий значение

int Method3() //Возвратный метод возвращающий значение
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

//Вид 4 // Методы которые принимают значения и возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//       while ( i < count)
//       {
//         result = result + text;
//         i++;
//       }
//       return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// этот подвид с циклом FOR все счетчики объявляются внутри

string Method4a(int count, string text)
{
    string result = String.Empty;
    for( int i =0; i < count; i++)
    {
        result = result + text;
    }
      return result;
}
// string res = Method4a(10, "asdf");
// Console.WriteLine(res);

// построение таблицы умножения

for (int i = 2; i <= 10; i++) // внешний ЦИКЛ 
{
    for (int j = 2; j < 10; j++)
    {
      Console.WriteLine($"{i} x {j} = {i * j}");
    } 
    Console.WriteLine();
}

