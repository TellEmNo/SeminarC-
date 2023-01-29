// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
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

void Print2dArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " "); ;
		Console.WriteLine();
	}
	Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
	if (row1 >= 0 && row1 < array.GetLength(0) &&
		row2 >= 0 && row2 < array.GetLength(0) &&
		row1 != row2)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			int temp = array[row1, j];
			array[row1, j] = array[row2, j];
			array[row2, j] = temp;
		}
	}
}

int[,] matrix = CreateMatrix();

Print2dArray(matrix);

Console.Write("Input a number of the first row: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second row: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(matrix, r1, r2);
Print2dArray(matrix);
 */
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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

void Print2dArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " "); ;
		Console.WriteLine();
	}
	Console.WriteLine();
}

int[,] ChangeRowsOnColumns(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = i + 1; j < array.GetLength(1); j++)
		{
			int temp = array[i, j];
			array[i, j] = array[j, i];
			array[j, i] = temp;
		}
	}
	return array;
}

int[,] matrix = CreateMatrix();

Print2dArray(matrix);

int[,] result = ChangeRowsOnColumns(matrix);

Print2dArray(result);
 */
// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

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

void Print2dArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " "); ;
		Console.WriteLine();
	}
	Console.WriteLine();
}

int[] CoordinateMinElement(int[,] array)
{
	int x = 0;
	int y = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[x, y] > array[i, j])
			{
				x = i;
				y = j;
			}
		}
	}
	int[] indexes = { x, y };
	return indexes;

}

int[,] DeleteRowAndColumn(int[,] array, int[] indexes)
{
	int[,] new2dArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
	for (int i = 0, n = 0; i < array.GetLength(0); i++, n++)
	{
		if (indexes[0] != i)
		{
			for (int j = 0, k = 0; j < array.GetLength(1); j++, k++)
			{
				if (indexes[1] != j)
					new2dArray[n, k] = array[i, j];
				else
					k--;
			}
		}
		else
			n--;
	}
	return new2dArray;
}

int[,] matrix = CreateMatrix();

Print2dArray(matrix);

int[] indexes = CoordinateMinElement(matrix);

int[,] new2dArray = DeleteRowAndColumn(matrix, indexes);

Print2dArray(new2dArray);