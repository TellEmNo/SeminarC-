// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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

	double[,] matrix = new double[rows, columns];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
			Console.Write($"{Math.Round(matrix[i, j], 2)} ");
		}
		Console.WriteLine();
	}
}

CreateAndPrintMatrix();
 */
// Задача 50.Напишите программу, которая на вход принимает позицию элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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

	int[,] mtrxArray = new int[rows, columns];

	for (int i = 0; i < mtrxArray.GetLength(0); i++)
		for (int j = 0; j < mtrxArray.GetLength(1); j++)
			mtrxArray[i, j] = new Random().Next(minValue, maxValue);
	return mtrxArray;
}

void PrintMatrix(int[,] mtrxArray)
{
	for (int i = 0; i < mtrxArray.GetLength(0); i++)
	{
		for (int j = 0; j < mtrxArray.GetLength(1); j++)
			Console.Write($"{mtrxArray[i, j]}  ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

bool CheckPosition(int[,] mtrxArray, int x, int y)
{
	if (x > mtrxArray.GetLength(0) - 1 || y > mtrxArray.GetLength(1) - 1)
		return false;
	else
		return true;
}
int[,] matrix = CreateMatrix();

Console.WriteLine("Введите координаты:");

Console.Write("x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PrintMatrix(matrix);

bool yN = CheckPosition(matrix, x, y);

if (yN == false)
	Console.WriteLine("Такого элемента не существует в этом двумерном массиве. ");
else
	Console.WriteLine($"Значение элемента, удовлетворяющего координатам (x,y) = {matrix[x, y]} ");
 */
// Задача 52.Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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

	int[,] mtrxArray = new int[rows, columns];
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			mtrxArray[i, j] = new Random().Next(minValue, maxValue);
		}
	}
	return mtrxArray;
}

void ShowMatrix(int[,] mtrx)
{
	for (int i = 0; i < mtrx.GetLength(0); i++)
	{
		for (int j = 0; j < mtrx.GetLength(1); j++)
			Console.Write($"{mtrx[i, j]}  ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

double[] AverageMeansOfColumns(int[,] mtrx)
{
	double[] resultArray = new double[mtrx.GetLength(1)];

	for (int j = 0; j < mtrx.GetLength(1); j++)
	{
		for (int i = 0; i < mtrx.GetLength(0); i++)
		{
			resultArray[j] += mtrx[i, j];
		}
		resultArray[j] = resultArray[j] / mtrx.GetLength(0);
	}
	return resultArray;
}

void ShowArray(double[] mtrx)
{
	for (int i = 0; i < mtrx.GetLength(0); i++)
		Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {Math.Round(mtrx[i], 2)}  ");
}

int[,] matrix = CreateMatrix();

ShowMatrix(matrix);

double[] resultArray = AverageMeansOfColumns(matrix);

ShowArray(resultArray);