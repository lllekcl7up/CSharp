// Найти максимальную цифру из рандомного трёх значного числа. Используя метод.


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
// например 456

int MaxDigit(int number)
{
int num1 = number / 100;
// 456 делим на 100 = 4 ... (получили 1 цифру )
int num2 = number % 100 / 10;
//456 получаем остаток от деления = 56 и делим на 10 = 5 (получили 2 цифру)
int num3 = number % 10;
//456 получаем остаток от деленя = 6 (получили 3 цифру)
int max = 0;
if (num1 > max) max = num1;
if (num2 > max) max = num2;// тут мы перебираем какое из чисел больше и присваевая значения max
if (num3 > max) max = num3;
return max;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"Максимальная цифра {maxDigit}");
// Console.WriteLine($"Максимальная цифра числа {max}");

