// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine();
Console.WriteLine("Например, задан массив:");

int[,] CreateMatrixRnd(int row, int col)//, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)   //row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //col
        {
            matrix[i, j] = i + j;
            matrix[i, j] = new Random().Next(0, 10);
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
            Console.Write($"{matrix[i, j],2}");
            if (j != matrix.GetLength(1) - 1) Console.Write(",");
        }
        Console.Write(" |");
        Console.WriteLine();
    }
}
int[,] mat = CreateMatrixRnd(3, 4);
PrintMatrix(mat);

Console.WriteLine();
Console.WriteLine("В итоге получается вот такой массив:");

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < mat.GetLength(1) - 1; k++)
        {
            if (mat[i, k] < mat[i, k + 1])
            {
                int temp = 0;
                temp = mat[i, k];
                mat[i, k] = mat[i, k + 1];
                mat[i, k + 1] = temp;
            }
        }
    }
}
PrintMatrix(mat);