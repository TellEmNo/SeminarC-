// Задача 1. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/* 
int Pow(int a, int b){
	int result = 1;

	for (int i = 0; i < b ; i++)
		result *= a;

	if (b < 0) result = -1;
	return result;
}

Console.WriteLine("Input 'A' and 'B':");

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int result = Pow(A, B);

if(result == -1)
	Console.WriteLine(" Я возвожу только в натуральную степень");
else
	Console.Write($"'A' to the power of 'B' = {result}");
	*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* 
int SumOfNumbers(int number){
	int sum = 0;

	while(number > 0){
		int count = number % 10;
		number = number / 10;
		sum += count;
	}
	return sum;
}

Console.Write("Input a number: ");

int number = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNumbers(number);

Console.WriteLine($"Sum of numbers: {sum}");
 */

// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size){
	int[] array = new int[size];

	for (int i = 0; i < size; i++){
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}

void ShowCreatedArray(int[] array){
	for (int i = 0; i < array.Length; i++){
		Console.Write(array[i] +" ");
	}
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);

ShowCreatedArray(array); 