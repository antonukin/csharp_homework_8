/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
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

int[,] MultiplyMatrices(int[,] matrix, int[,] matr)
{
    int[,] resultMatrix = new int[matrix.GetLength(1), matr.GetLength(0)];
    if(matrix.GetLength(1) != matr.GetLength(0))
    {
        Console.WriteLine("Матрицы умножать нельзя");
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int z = 0; z < matr.GetLength(0); z++)
                {
                    resultMatrix[i, j] += matrix[i, z] * matr[z, j];
                }
            }

        }
    }
    return resultMatrix;
}


int[,] firstMatrix = GetMatrix(2, 2);
int[,] secondMatrix = GetMatrix(2, 2);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] resultMatrix = MultiplyMatrices(firstMatrix, secondMatrix);
PrintMatrix(resultMatrix);