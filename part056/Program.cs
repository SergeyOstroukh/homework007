// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreatMatrixArray(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrixArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1)) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.Write("]");
        Console.WriteLine();
    }

}

int[] MatrixSumRows(int[,] matrix)
{
    int[] sumElements = new int[matrix.GetLength(1) + 1];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sumElements[i] = sum;
        sum = 0;

    }
    return sumElements;
}

void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write("[");
        if (i < matrix.Length) Console.Write($"{matrix[i]} ");
        else Console.Write($"{matrix[i]}");
        Console.Write("]");
    }
}

int MaxNumberInRowsArray(int[] array)
{
    int muxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= muxNumber)
        {
            muxNumber = array[i];
        }
    }
    return muxNumber;
}


int[,] arrayMatrix = CreatMatrixArray(5, 4, 1, 100);
PrintMatrixArray(arrayMatrix);
Console.WriteLine();
int[] matrixResult = MatrixSumRows(arrayMatrix);
Console.Write($"Сумма каждой строки матрицы: ");
PrintArray(matrixResult);
Console.WriteLine();
PrintArray(matrixResult);
int numberInRowsArray = MaxNumberInRowsArray(matrixResult);
Console.WriteLine($" -> Максимально число среди суммы всех строк {numberInRowsArray}");