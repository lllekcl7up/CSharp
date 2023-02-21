// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со хначением первой неотсортированной позиции.
// 3. Повторять пока есть не отсортированные элементы.

// чтобы последовательность производилась в обратном порядке нужно
// в 30 строке поменять знак < на > и тогда метод будет искать максимальные значения.

int [] arr = {7, 3, 1, 6, 8 , 3, 2, 4, 5, 9, 4,};

void PrintArray(int [] array) // подзадача выводит массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSrt(int[] array) // Метод который упорядочивает массив 
{
    for ( int i = 0; i < array.Length - 1; i++)
    {
        
        int minPosition = i; //создал переменную с минимальной позицией

        for ( int j = i + 1; j < array.Length; j++)
        {                           // этот блок кода ищет минимальный эллемент
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];// создал временную переменную 
        array[i] = array[minPosition]; // тут элементу массива [i] присваиваем минимальную позицию 
        array[minPosition] = temporary; // тут в минимальную позицию кладем временный элемент
    }
}

PrintArray(arr);
SelectionSrt(arr);

PrintArray(arr);