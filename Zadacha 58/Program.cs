// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int value = InputInt("Величина матриц: ");

void FillMatrixRndNum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 5);
        }
    }
}
int[,] matA = new int[value, value];
FillMatrixRndNum(matA);

int[,] matB = new int[value, value];
FillMatrixRndNum(matB);

int[,] matC = new int[value, value];

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}
Console.WriteLine("Первая:");
PrintMatrix(matA);
Console.WriteLine();
Console.WriteLine("Вторая:");
PrintMatrix(matB);
Console.WriteLine();


for (int i = 0; i < value; i++)
{
    for (int j = 0; j < value; j++)
    {
        for (int k = 0; k < value; k++)
        {
            matC[i, j] = matC[i, j] + (matA[i, k] * matB[k, j]);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine("Результирующая матрица будет:");
PrintMatrix(matC);


