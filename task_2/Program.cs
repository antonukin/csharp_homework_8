/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int SumOfElementsInRows(int[,] matrix)
{
    int smallestRow = 0;
    int smallestSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentSum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                currentSum += matrix[i, j];
            }
        if(currentSum < smallestSum)
        {
            smallestRow = i;
            smallestSum = currentSum;
        }
        else continue;
    }
    return smallestRow + 1;
}

int rows = GetNumber("Введите количество строк");
int cols = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();
int largestRow = SumOfElementsInRows(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов - {largestRow}-я");