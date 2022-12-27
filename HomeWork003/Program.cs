// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrome(int num)
{
	int a = num / 10000;
	int b = num / 1000 % 10;
	int c = num % 100 / 10;
	int d = num % 10;
	if (a == d && b == c)
		return true;
	else
		return false;
}

Console.Write("input five-digit number: ");
int xlx = Convert.ToInt32(Console.ReadLine());
if (xlx < 10000 || xlx > 99999)
{
	Console.Write("Try again: ");
	xlx = Convert.ToInt32(Console.ReadLine());
}

bool p = Palindrome(xlx);
Console.WriteLine($"{xlx} is Palindrome? {p}");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Method(double xa, double ya, double za, double xb, double yb, double zb)
{
	double result = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
	return result;
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

double res = Method(x1, y1, z1, x2, y2, z2);
double result = Math.Round(res, 2);
Console.WriteLine($"Distance between coordinates: {result}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{
	double result = 0;
	for (int i = 1; i <= n; i++)
	{
		result = Math.Pow(i, 3);
		Console.Write($"{result} ");
	}
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);