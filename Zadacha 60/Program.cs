// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)




Console.WriteLine("Массив размером 2 x 2 x 2: ");
int mas1 = 2;
int mas2 = 2;
int mas3 = 2;
int sumMas = mas1 * mas2 * mas3;

if (sumMas > 99)
{
    Console.Write("Массив слишком большой");
    return;
}


int[,,] resNum = Create3DMassive(mas1, mas2, mas3);

for (int i = 0; i < resNum.GetLength(0); i++)
{
    for (int j = 0; j < resNum.GetLength(1); j++)
    {
        for (int f = 0; f < resNum.GetLength(2); f++)
        {
            Console.WriteLine($"[{i},{j},{f}] - {resNum[i, j, f]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int[,,] Create3DMassive(int raz1, int raz2, int raz3)
{
    int[,,] matrix = new int[raz1, raz2, raz3];
    int[] sum = new int[99];
    int num = 1;
    for (int i = 0; i < sum.Length; i++)
        sum[i] = num
        ++;

    for (int i = 0; i < sum.Length; i++)
    {
        int randomInd = new Random().Next(0, sum.Length);
        int temp = sum[i];
        sum[i] = sum[randomInd];
        sum[randomInd] = temp;
    }

    int sumIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(2); f++)
            {
                matrix[i, j, f] = sum[sumIndex++];
            }
        }
    }
    return matrix;
}



