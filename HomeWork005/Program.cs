// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] RandomArray(int size){
	int[] array = new int[size];

	for (int i = 0; i < size; i++){
		array[i] = new Random().Next(100, 1000);
	}
	return array;
}

void ShowArray(int[] array){
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}

int EvenNumber(int[] array){
	int count = 0;
	for (int i = 0; i < array.Length; i++)
		if(array[i] % 2 == 0) count++;

	return count;
}


Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(m);

ShowArray(newArray);

int count = EvenNumber(newArray);
Console.WriteLine(count);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] RandomArray(int size, int minValue, int maxValue){
	int[] array = new int[size];

	for (int i = 0; i < size; i++){
		array[i] = new Random().Next(minValue, maxValue + 1);
	}
	return array;
}

void ShowArray(int[] array){
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}

int OddSum(int[] array){
	int result = 0;
	for (int i = 0; i < array.Length; i++)
		if(i % 2 == 1) result += array[i];
	return result;
}


Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);

int result = OddSum(newArray);
Console.WriteLine("Sum of odd numbers = " + result);
*/

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomArray(int size, int minValue, int maxValue){
	double[] array = new double [size];

	for (int i = 0; i < size; i++)
		array[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble() ,2);
	return array;
}

void ShowArray(double[] array){

	for (int i = 0; i < array.Length; i++)
		Console.Write(Math.Round(array[i], 2)+ " ");

	Console.WriteLine();
}

double MaxMinusMin(double[] array){
	double max = array[0];
	double min = array[0];
	double result = 0;

	for (int i = 0; i < array.Length; i++){
		if(array[i] > max) max = array[i];
		if(array[i] < min) min = array[i];
	}
	result = max - min;
	return result;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = RandomArray(m, min, max);

ShowArray(newArray);

double result = MaxMinusMin(newArray);

Console.Write($"max - min = {Math.Round(result, 2)} ");