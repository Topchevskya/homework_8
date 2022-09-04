// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int i, j;
int[,] firstMatrix = new int[2, 2] { { 2, 4 }, { 3, 2 } };

for (int m = 0; m < 2; m++)
{
    for (int n = 0; n < 2; n++)
    {
        Console.Write(firstMatrix[m, n] + "\t");;
    }
    Console.WriteLine();
}
Console.WriteLine("-----------");
int[,] secondMatrix = new int[2, 2] { { 3, 4 }, { 3, 3 } };

for (int r = 0; r < 2; r++)
{
    for (int q = 0; q < 2; q++)
    {
        Console.Write($"{secondMatrix[r, q]} \t");
    }
    Console.WriteLine();
}

int i, j;
Console.WriteLine("Результатирующая матрица:");
int[,] resultMatrix = new int[2, 2];
for (i = 0; i < 2; i++)
{
    for (j = 0; j < 2; j++)
    {


        resultMatrix[i, j] = 0;
        for (int k = 0; k < 2; k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}
for (i = 0; i < 2; i++)
{
    for (j = 0; j < 2; j++)
    {
        Console.Write(resultMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}

