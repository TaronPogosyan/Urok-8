// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
int[,] mat = CreateMatrixRnd(3, 5);
PrintMatrix(mat);

int minSuma = Int32.MaxValue;
int inRow = 0;

for (int i = 0; i < mat.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        sum = sum + mat[i, j];
    }
    if (sum < minSuma)
    {
        minSuma = sum;
        inRow++;
    }
}

Console.WriteLine();
Console.WriteLine("Строка: " + (inRow) + ", с наименьшей суммой элементов: " + (minSuma));