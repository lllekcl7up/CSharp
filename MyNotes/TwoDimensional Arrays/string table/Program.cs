string[,] table = new string [2,5]; //тут мы указываем количество строк и количество столбцов 
// по умолчанию строки инициализируются пустой строкой ничего не содержащей String.Empty
// table [0,0]   table [0,1]   table [0,2]   table [0.4]
// table [1,0]   table [1,1]   table [1,2]   table [1.4]


// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++) 
// // в первом цикле мы указываем колличество строк у нас их 2 
// {
//     for (int columns = 0; columns < 5; columns++)
//     //во внутренем цикле указываем кобичество столбцов у нас их 5
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }


void PrintArray(int[,] matr) // этот метод в качестве аргумента принимает двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {// тут мы указывваем количество СТРОК (0) 
        for (int j = 0; j < matr.GetLength(1); j++)
        {// тут мы указываем колличество СТОЛБЦОВ (1)
            Console.Write
            ($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}



int [,] matrix = new int [3,4]; // тут двумерный массив с числами
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
