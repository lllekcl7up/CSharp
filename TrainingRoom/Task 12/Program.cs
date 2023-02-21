// Пользователь вводит натуральное число. Определить :
// а) является ли оно четным;
// б) оканчивается ли оно цифрой 7.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number % 2 == 0) // если number делится на 2 без остатка
{
    Console.WriteLine($"Число {number} четное");
}
else Console.WriteLine($"Число {number} не четное");

if ( number % 10 == 7) //если number делится на 10 и остаток 7
{
    Console.WriteLine($"Число {number} оканчивается на 7");
}
else Console.WriteLine($"Число {number} не оканчивается на 7");

// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool ChekcNumber(int num)
// {
//      return num % 2 == 0 && num % 10 == 7;
// //     {
// //     return  false;
// //     }
// //    else return true;
// }
// bool a = ChekcNumber(number);
// Console.WriteLine($"Число {number} чётное и не заканчивается на 7 {a}");

// if ( number > 0)
// {
//     bool a = ChekcNumber(number);
//     Console.Write($"Число {number} четное и не зканчивается на 7 {a}");
// }
// else
//     Console.Write("Вы ввели отрицательно число");
