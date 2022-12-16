// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


void CheckCoordAndFillMatrix(int[,] matrix, int row, int col)
{
    if (row == col)
        Console.WriteLine($"Задан неверный размер матрицы");
    else
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


void MinSumElements(int[,] matrix)
{
    int sum = 0;
    int minSum = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += matrix[i, j];
                minSum += matrix[i, j];
            }
            else sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i + 1} = {sum}");

        if (sum < minSum)
        {
            minSum = sum;
            count = i;
        }
        sum = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {count + 1}");
}

Console.Clear();
Console.Write("Введите размеры прямоугольной матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int row = int.Parse(numbers[0]),
    col = int.Parse(numbers[1]);
int[,] matrix = new int[row, col];
CheckCoordAndFillMatrix(matrix, row, col);
Console.WriteLine();
MinSumElements(matrix);

