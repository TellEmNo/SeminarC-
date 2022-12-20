// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int Midnumb(int middle)
{
	int mid = middle / 10 % 10;
	return mid;
}

Console.Write("Input a three-digit number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb < 100 || numb > 999)
	Console.WriteLine("Error. Input a three-digit number: ");

else
{
	int mid = Midnumb(numb);
	Console.WriteLine($"Middle number is: {mid}");
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Week(int day)
{
	if (day == 6 || day == 7)
		return true;
	else
		return false;
}

Console.Write("input the day of the week ");
int day = Convert.ToInt32(Console.ReadLine());

if (Week(day))
	Console.WriteLine("It's a day off");
else
	Console.WriteLine("It's a weekday");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber(int numb)
{
	while (numb > 1000)
		numb = numb / 10;
	return numb;
}

Console.Write("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());

int thirdN = ThirdNumber(numb);

if (thirdN > 99)
	Console.WriteLine($"Third number is {thirdN % 10}");
else
	Console.WriteLine("No third number");
