// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMatrixFirst(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FillMatrixSecond(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// void MultiplicationOfTwoMatrices(int[,] resultMatrix, int[,] matrixFirst, int[,] matrixSecond)
// {
//     for (int i = 0; i < matrixFirst.GetLength(0); i++)
//     {
//         for (int m = 0; m < matrixSecond.GetLength(0); m++)
//         {
//             for (int j = 0; j < matrixFirst.GetLength(1); j++)
//             {
//                 for (int n = 0; n < matrixSecond.GetLength(1); n++)
//                 {
//                     resultMatrix[] = matrixFirst[i, j] * matrixSecond[m, n];
//                     Console.Write($"Новый массив: {result} \t");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

void MultiplicationOfTwoMatrices(int[,] matrixFirst, int[,] matrixSecond, int[,] resultMatrix)
{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            resultMatrix[i, j] = matrixFirst[i, j] * matrixSecond[i, j];
        }
    }

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            Console.Write($"{resultMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}



Console.Clear();

Console.Write($"Введите размерность двух двумерных массивов: ");
int[] coordMatrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixFirst = new int[coordMatrix[0], coordMatrix[1]];
int[,] matrixSecond = new int[coordMatrix[0], coordMatrix[1]];
int[,] resultMatrix = new int[coordMatrix[0], coordMatrix[1]];

Console.WriteLine("Первый массив:");
FillMatrixFirst(matrixFirst);
Console.WriteLine();

Console.WriteLine("Второй массив:");
FillMatrixSecond(matrixSecond);
Console.WriteLine();

Console.WriteLine("Новый массив с перемноженными значениями:");
MultiplicationOfTwoMatrices(matrixFirst, matrixSecond, resultMatrix);