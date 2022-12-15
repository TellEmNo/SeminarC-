// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
	Console.Write($"Maximum number: {n1} ");
	Console.Write($"Minimum number: {n2}");
}
else
{
	Console.Write($"Maximum number: {n2} ");
	Console.Write($"Minimum number: {n1}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
	max = b;
if (max < c)
	max = c;

Console.Write($"Maximum number: {max}");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
	Console.Write($"Number {number} is even");

else
	Console.Write($"Number {number} is odd");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= N)
{
	if (current % 2 == 0)
	{
		Console.Write($"{current + " "}");
	}
	current++;
}
*/