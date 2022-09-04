// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows;
int columns;
int[,] matrix;

Console.Write("Введите количество строк в матрице: ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
columns = Convert.ToInt32(Console.ReadLine());

matrix = new int[rows, columns];

Console.WriteLine("Задан массив:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
}

int minRowSum = int.MaxValue, indexMinRow = 0;

for (int i = 0; i < rows; i++)
{
    int rowSum = 0;
    for (int j = 0; j < columns; j++)
        rowSum += matrix[i, j];

    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальная сумма элементов в {indexMinRow} строке");

