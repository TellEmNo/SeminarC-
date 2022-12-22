//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void GetDiapazone(int quadrant)
{
	if (quadrant == 1) Console.WriteLine("x > 0 and y > 0");
	else if (quadrant == 2) Console.WriteLine("x < 0 and y > 0");
	else if (quadrant == 3) Console.WriteLine("x < 0 and y < 0");
	else if (quadrant == 4) Console.WriteLine("x > 0 and y < 0");
	else Console.WriteLine("Wrong input!");
}

Console.Write("input a number of quadrant: ");
int quadNumb = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNumb);
*/
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int QuadrantNumb(int x, int y)
{
	int quad = 0;
	if (x > 0 && y > 0)
		quad = 1;
	else if (x < 0 && y > 0)
		quad = 2;
	else if (x < 0 && y < 0)
		quad = 3;
	else if (x < 0 && y > 0)
		quad = 4;
	return quad;
}
Console.Write("input x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
	Console.WriteLine("Wrong input");
else
	Console.WriteLine($"Quadrant {QuadrantNumb(x, y)}");
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
/*
void Quad(int n)
{
	int result = 0;
	for (int i = 1; i <= n; i++)
	{
		result = i * i;
		Console.WriteLine($"{result} ");
	}
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Quad(n);
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Method(double xa, double ya, double xb, double yb)
{
	double result = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));
	return result;
}

Console.WriteLine("x1, y1, x2, y2");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double res = Method(x1, y1, x2, y2);
Console.WriteLine(res);
