/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && (result >= 0))
        {
        break;
        }
        else
        {
        Console.WriteLine("Ввели не число или не корректное число.");
        }
    }
    return result;
}

int[,] GetMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for(int k = j + 1; k < matrix.GetLength(1); k++)
                {
                if(matrix[i, k] > matrix[i, maxPosition]) maxPosition = k;
                }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxPosition];
            matrix[i, maxPosition] = temp;
        }
    }        
}

int rows = GetNumber("Введите количество строк");
int cols = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);