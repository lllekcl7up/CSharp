//Даны два действительных числа x и у. Вычислить их сумму, разность, произведение и частное 

double x = new Random().NextDouble(); // Работает от 0 до 1 
double y = new Random().NextDouble();

Console.WriteLine("Какие числа мы вычисляем");
Console.WriteLine(x);
Console.WriteLine(y);

Console.Write("Cумма чисел = ");
Console.WriteLine(x + y);

Console.Write("Разность чисел = ");
Console.WriteLine(x - y);

Console.Write("Произведение чисел = ");
Console.WriteLine(x * y);

Console.Write("Частность чисел = ");
Console.WriteLine(x / y);
