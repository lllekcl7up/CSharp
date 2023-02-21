// S1.1. Вывести на экран число  с точностью до сотых.

// double number = 12.4567;
// number = Math.Round(number, 2);
// Console.WriteLine(number);


// S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. 
//Выводимому числу должно предшествовать сообщение «Вы ввели число».

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вы ввели: {number} ");


// S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры.
// После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} - вот какое число Вы ввели");


// S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

// Console.WriteLine ("1 13 49"); Но это строка.
// int numA = 1, numB = 13, numC = 49;
// Console.WriteLine ($"{numA} {numB} {numC} ");

// S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.

// int numA = 7, numB = 15, numC = 100;
// Console.WriteLine($"{numA}  {numB}  {numC}");


// S1.7. Составить программу вывода на экран 
// в одну строку трех любых чисел с двумя пробелами между ними.

// int numA = new Random().Next(); после Next в скобках можно ввести любые числа
// int numB = new Random().Next(); для ограничения деапазона 
// int numC = new Random().Next();
// Console.WriteLine($" {numA}  {numB}  {numC}");

// S1.8. Составить программу вывода на экран в одну строку 
// четырех любых чисел  с одним пробелом между ними.

// int numA = new Random().Next();
// int numB = new Random().Next();
// int numC = new Random().Next();
// int numD = new Random().Next();
// Console.WriteLine($" {numA} {numB} {numC} {numD}");


// S1.9. Вывести на экран числа 50 и 10 одно под другим.

// Console.WriteLine(50);  // Строки
// Console.WriteLine(10);

// int numA = 50, numB = 10;
// Console.WriteLine($"{numA}");
// Console.WriteLine($"{numB}");


// S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.

// int numA = 5, numB = 10, numC = 21;
// Console.WriteLine($"{numA}");
// Console.WriteLine($"{numB}");
// Console.WriteLine($"{numC}");


// S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел

// int numA = new Random().Next();
// int numB = new Random().Next();
// int numC = new Random().Next();
// int numD = new Random().Next();

// Console.WriteLine($"{numA} \n{numB} \n{numC} \n{numD}"); // тоже будет столбик

// Console.WriteLine($"{numA}");      // Вариант 1 
// Console.WriteLine($"{numB}");
// Console.WriteLine($"{numC}");
// Console.WriteLine($"{numD}");







// Console.WriteLine(new Random().Next());
// Console.WriteLine(new Random().Next());  
// Console.WriteLine(new Random().Next());     // Вариант 2
// Console.WriteLine(new Random().Next());

// S1.12. Составить программу вывода на экран следующей информации:
// 5 10
// 7 см

// Console.WriteLine("5 10");
// Console.WriteLine("7 cm");

// Console.WriteLine("5 10 \n7 cm"); // можно так 
                //  \n  это сделает абзац 


// S1.13. Составить программу вывода на экран следующей информации:
// 2 кг
// 13 17

// Console.WriteLine("2 кг \n13 17");