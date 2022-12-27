// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int number)
{
	int sot = number / 100;
	int ed = number % 10;
	int result = sot * 10 + ed;
	return result;
}

int randNumber = new Random().Next(100, 1000);
Console.WriteLine($"Current random three-digit number is {randNumber}");

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of number is {newNumber}");
//или Console.WriteLine($"New version of number is {CutNumber(randNumber)}"); - работает в рамках элементарных задач
*/

/*
bool IsEven(int num)
{
	if(num % 2 == 0)
		return true;
	else
	{
		return false;
	}
}
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int Number(int numb)
{
	int des = numb / 10;
	int ed = numb % 10;
	int max = 0;
	if (des > ed)
	{
		max = des;
	}
	else
	{
		max = ed;
	}
	return max;
}

int randNumber = new Random().Next(10, 100);
Console.WriteLine($"Current random two-digit number is {randNumber}");

int result = Number(randNumber);
Console.WriteLine(result);
*/
//Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому.
/*
bool Method(int a, int b)
{
	if (b % a == 0)
	{
		return true;
	}
	else
	{
		return false;
	}

}

Console.WriteLine("Введите два числа ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
bool tf = Method(num1, num2);
Console.WriteLine(tf);
*/
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Method(int a, int b)
{
	if (a == b * b || b == a * a)
	{
		return true;
	}
	else
	{
		return false;
	}
}

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool tf = Method(num1, num2);
Console.WriteLine(tf);

if (Method(num1, num2))
{
	Console.WriteLine("Одно из чисел квадрат другого");
}
else
{
	Console.WriteLine("Ни одно из чисел не квадрат другого");
}