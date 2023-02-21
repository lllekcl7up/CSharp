// Задача 3. В заданной строке текста определите количество слов.
//  Каждое слово отделено друг от друга пробелом.

// Console.WriteLine("press something");
// string line = Console.ReadLine();
// string space = " ";
// int i, words = 1, letter = 0;
// for (i = 0; i != line.Length; i++)
// {
//    if (line[i] != space[0]) 
//       letter++;
//    else
//       words++;
// }
// Console.WriteLine("Ваш текст: " + line);
// Console.WriteLine("Слов {0} Букв {1}", words, letter);
// Console.ReadKey();

// Задача 6. В одномерном массиве из 100 чисел M[] подсчитайте количество
//  элементов, удовлетворяющих условию 0 < M[i] <125.

// int[] CreateArrayRandomInt (int size, int min, int max)
// {
//     int [] array = new int [size];
//     Random rndm = new Random();
    
//     for(int index = 0; index < array.Length; index = index + 1)
//     {
//         array[index] = rndm.Next( min, max+1 );// с учетом последнего индекса поэтому + 1
//     }
//     return array;
// }

// void PrintArray(int[] arr, string symb1, string symb2)
// {
//     Console.Write(symb1);
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write(symb2);
// }

// int CountElements(int [] array)
// {
//     int count = default;
//     for (int i = 0; i <array.Length; i++)
//     {
//         if (array[i] > 0 && array[i] < 125) count = count + 1;
//     }
//     return count;
// }

// int [] arrayCreate = CreateArrayRandomInt(10, -100, 200);
// PrintArray(arrayCreate, "[", "]");
// int countElements = CountElements(arrayCreate);
// Console.Write($"\nКолличество элементов удовлетворяющих условию 0 < M[i] <125 = {countElements}");


