// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// [0,0] [0,1] [0,2] [0,3]
// [1,0] [1,1] [1,2] [1,3]
// [2,0] [2,1] [2,2] [2,3]
// [3,0] [3,1] [3,2] [3,3]

void FillingMatrixSpiral(int[,] matrix, int sizeMatrix, int i, int j, int count)
{
    while (count <= sizeMatrix * sizeMatrix)
    {
        matrix[i, j] = count;
        if (i <= j + 1 && i + j < sizeMatrix - 1)
            ++j;
        else if (i < j && i + j >= sizeMatrix - 1)
            ++i;
        else if (i >= j && i + j > sizeMatrix - 1)
            --j;
        else
            --i;
        count++;
    }
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int sizeMatrix = 4;
int[,] matrix = new int[sizeMatrix, sizeMatrix];
int row = 0;
int col = 0;
int count = 1;
Console.WriteLine("Массив, заполненный спирально:");
FillingMatrixSpiral(matrix, sizeMatrix, row, col, count);
