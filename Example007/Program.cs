// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aij = i+j. Выведите полученный массив на экран.
/* 
void CreateAndPrintMatrix()
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
			matrix[i, j] = i + j;
			Console.Write($"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}
}

CreateAndPrintMatrix();
 */
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
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
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i, j] = new Random().Next(minValue, maxValue + 1);
	return matrix;
}

void Show2dArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " "); ;
		Console.WriteLine();
	}
	Console.WriteLine();
}

int[,] IsEvenIndex(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i += 2)
		for (int j = 0; j < matrix.GetLength(1); j += 2)
			matrix[i, j] = matrix[i, j] * matrix[i, j];
	return matrix;
}

int[,] matrix = CreateMatrix();

Show2dArray(matrix);

int[,] secondMatrix = IsEvenIndex(matrix);

Show2dArray(secondMatrix);
 */

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1; 1) и т.д.

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
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i, j] = new Random().Next(minValue, maxValue + 1);
	return matrix;
}

void Show2dArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " "); ;
		Console.WriteLine();
	}
	Console.WriteLine();
}

int SumElements(int[,] matrix)
{
	int result = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
		result += matrix[i, i];
	return result;
}

int[,] matrix = CreateMatrix();

Show2dArray(matrix);

int result = SumElements(matrix);

Console.WriteLine(result);