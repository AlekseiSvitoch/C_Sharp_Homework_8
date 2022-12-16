// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrix(int[,,] matrix)
{
    int count = 10;
    while(count < 98) // если больше значения "98" - последние значения массива выводятся уже как 3х значные числа
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {     
                    matrix[i, j, k] = count++;
                    Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) \t");
                }
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write($"Введите размерность трехмерного массива через пробел: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[coord[0], coord[1], coord[2]];
Console.WriteLine("Полученный массив:");
FillMatrix(matrix);
Console.WriteLine();
