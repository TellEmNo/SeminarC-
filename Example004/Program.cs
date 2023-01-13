// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/* int Sum(int a)
{
	int result = 0;

	for (int i = 1; i <= a; i++)
		result += i;
	return result;
}

Console.Write("Input a number: ");
int numbA = Convert.ToInt32(Console.ReadLine());

int result = Sum(numbA);

Console.WriteLine($"Сумма всех чисел от 1 до a = {result}"); */

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/* int Numbers(int n){
	int count = 0;
	while(n != 0)
	{
		n = n / 10 ;
		count += 1;
	}
	return count;
}

Console.WriteLine("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());

int result = Numbers(numb);

Console.WriteLine($"{result}"); */

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/* int Sum(int a)
{
	int result = 1;

	for (int i = 1; i <= a; i++)
		result = result * i;
	return result;
}

Console.Write("Input a number: ");
int numbA = Convert.ToInt32(Console.ReadLine());

int result = Sum(numbA);

Console.WriteLine($"Произведение чисел от 1 до a = {result}"); */

// Массивы

int[] RandomArray(int size, int minValue, int maxValue){
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
		array[i] = new Random().Next(minValue, maxValue + 1);
	
	return array;
}
// Next не воспринимает верхнюю границу и отрезает ее знаком <, поэтому приписываем верхней границе + 1
void ShowArray(int[] array){
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);

// Дз сделать метод, который запросит заполнить массив самостоятельно в третьей задаче
