// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

int[,] arrayMatrix = CreatMatrixArray(4, 4, 1, 100);
PrintMatrixArray(arrayMatrix);
Console.WriteLine();

if(ReplaceMatrix(arrayMatrix))
{
    PrintMatrixArray(ReplacementInArrayStringsonColums(arrayMatrix));
}


bool ReplaceMatrix(int[,] matrix)
{
     return (matrix.GetLength(0) == matrix.GetLength(1));
}

int[,] ReplacementInArrayStringsonColums(int[,] matrix)
{
    int[,] matrixArrayNumber = new int[matrix.GetLength(0), matrix.GetLength(1)];
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrixArrayNumber[j, i] = matrix[i, j];
            }
        }
    }
    return matrixArrayNumber;
}