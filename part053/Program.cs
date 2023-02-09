// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

void StringReplacementInArray(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1, i];
        matrix[matrix.GetLength(0)-1, i] = temp;
    }
}

int[,] matrixArray = CreatMatrixArray(3,4,1,100);
PrintMatrixArray(matrixArray);
Console.WriteLine();
StringReplacementInArray(matrixArray);
PrintMatrixArray(matrixArray);