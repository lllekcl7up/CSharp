// Создайте метод ChangeColumns для обмена определенных столбцов матрицы
// размера 3 на 4 (порядковые номера столбцов вводятся).

int[,] CreateMatrixRandomInt (int rows, int columns, int min, int max) 
{
    int [,] matrix = new int [rows, columns];
    Random rndm = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j] = rndm.Next( min, max+1 );
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1) 
            Console.Write($"{matrix[i,j], 4}| ");
            else Console.Write($"{matrix[i,j], 4}");
        }
    Console.WriteLine("|");
    }
}


int [,] ChangeColumns(int[,] matrix, int columnsA, int columnsB )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[i, columnsA];
        matrix[i, columnsA] = matrix[i, columnsB];
        matrix[i, columnsB] = temp;
    }
    return matrix;
}

int [,] array2D = CreateMatrixRandomInt(5,5,1,9);
PrintMatrix(array2D);
Console.WriteLine();
PrintMatrix(ChangeColumns(array2D , 0,1)); // тут в аргументах пишем какие столбцы меняем

