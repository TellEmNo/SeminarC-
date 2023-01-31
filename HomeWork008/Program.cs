// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/* 
int[,] CreateMatrix()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
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
    Console.WriteLine();
}

int[,] SortingElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
            {
                if (matrix[i, k] <= matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
int[,] sortedMatrix = SortingElements(matrix);
PrintMatrix(sortedMatrix);
 */

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* 
int[,] CreateMatrix()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
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
    Console.WriteLine();
}

int[] MinElementsSum(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i, j];
        }
    }
    return result;
}
void MinRow(int[] minElements)
{
    int minValueOfRows = minElements[0];
    int indexMinValueOfRows = 0;
    for (int i = 0; i < minElements.Length; i++)
    {
        if (minValueOfRows > minElements[i])
        {
            minValueOfRows = minElements[i];
            indexMinValueOfRows = i;
        }
        Console.Write($"{minElements[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов: {indexMinValueOfRows + 1}");
    Console.WriteLine();
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
int[] minElements = MinElementsSum(matrix);

MinRow(minElements);
 */

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* 
int[,] CreateMatrix()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
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
    Console.WriteLine();
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            for (int k = 0; k < matrix1.GetLength(1); k++) // или matrix2.GetLength(0)
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
    return resultMatrix;
}

int[,] matrix1 = CreateMatrix();
int[,] matrix2 = CreateMatrix();

PrintMatrix(matrix1);
PrintMatrix(matrix2);

int[,] resultMatrix = MatrixProduct(matrix1, matrix2);
PrintMatrix(resultMatrix);
 */

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* 
int[,,] CreateMatrix()
{
    Console.Write("Input a number of X: ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of Y: ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of Z: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[,,] matrix = new int[width, height, length];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = 0;
    return matrix;
}

int[,,] UniqueValues(int[,,] matrix, bool alreadyThere)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2);)
            {
                int newRandomValue = new Random().Next(10, 100);
                alreadyThere = false;
                for (int n = 0; n < matrix.GetLength(0); n++)
                    for (int m = 0; m < matrix.GetLength(1); m++)
                        for (int l = 0; l < matrix.GetLength(2); l++)
                        {
                            if (matrix[m, l, n] == newRandomValue)
                            {
                                alreadyThere = true;
                                break;
                            }
                        }
                if (alreadyThere == false)
                {
                    matrix[j, k, i] = newRandomValue;
                    k++;
                }
            }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[j, k, i]}{(j, k, i)} ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
}

int[,,] matrix = CreateMatrix();
bool alreadyThere = false;
UniqueValues(matrix, alreadyThere);
PrintMatrix(matrix);
 */
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

int[,] CreateMatrix(int n)
{
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = 0;
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
                Console.Write("0" + matrix[i, j] + " ");
            else
                Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SquareSpiral(int[,] matrix, int n)
{
    int i = 0;
    int j = -1;
    int value = 1;
    int moveRows = 0;
    int moveColumns = 1;
    while (value <= n * n)
        if (0 <= i + moveRows && i + moveRows < n && 0 <= j + moveColumns &&
        j + moveColumns < n && matrix[i + moveRows, j + moveColumns] == 0)
        {
            i += moveRows;
            j += moveColumns;
            matrix[i, j] = value;
            value++;
        }
        else
        {
            if (moveColumns == 1)
            {
                moveColumns = 0;
                moveRows = 1;
            }
            else if (moveRows == 1)
            {
                moveRows = 0;
                moveColumns = -1;
            }
            else if (moveColumns == -1)
            {
                moveColumns = 0;
                moveRows = -1;
            }
            else if (moveRows == -1)
            {
                moveRows = 0;
                moveColumns = 1;
            }
        }
    return matrix;
}
Console.Write("Задайте размер квадратной матрицы N x N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(n);
SquareSpiral(matrix, n);
PrintMatrix(matrix);