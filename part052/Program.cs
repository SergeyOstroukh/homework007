// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArray(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write("[");
        if (i < matrix.Length) Console.Write($"{matrix[i]} ");
        else Console.Write($"{matrix[i]}");
        Console.Write("]");
    }
}


double[] AverageNumber(int[,] matrix)
{
    double[] sumArray = new double[matrix.GetLength(1)];
    double sum = 0;
    double average = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
            
        }
        average = sum / matrix.GetLength(0);
        average = Math.Round(average, 1);
        sumArray[j] = average;
        sum = 0;
    }
    return sumArray;
}
int[,] creatMatrix = CreatMatrixArray(4, 4, 1, 100);
PrintMatrixArray(creatMatrix);
double[] averageNumber = AverageNumber(creatMatrix);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(averageNumber);