// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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

int[,] matrixArray = CreatMatrixArray(3, 4, 1, 100);

Console.WriteLine("Введите индексы элементвов: ");
Console.WriteLine("Index Pos1: ");
int posRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Index Pos2: ");
int posColums = Convert.ToInt32(Console.ReadLine());
// PrintMatrixArray(matrixArray);
if(posRows < 0 || posColums < 0)
{
  Console.Write("Введите положительное значение");
  return;
}
if(posRows > matrixArray.GetLength(0) && posColums > matrixArray.GetLength(1))
{
    Console.Write("элементов под такими индексами не существует");
  return;
}
PrintMatrixArray(matrixArray);
Console.Write($"Элемент индексов {posRows} и {posColums} найден, и имеет следующее значение: {matrixArray[posRows,posColums]}");