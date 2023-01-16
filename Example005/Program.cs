// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.
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

int GetSumOfNegative(int[] array){
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
		if (array[i] < 0) sum += array[i];
	
	return sum;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);

int result = GetSumOfNegative(newArray);
Console.WriteLine("Sum of negative elements is " + result);

 */

// Задача 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
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


int[] SignChange(int[] array){
	for (int i = 0; i < array.Length; i++)
		array[i] = array[i] * (-1);

	return array;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);

int[] qwerty = SignChange(newArray);
ShowArray(qwerty);
 */

// Задача 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
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


bool Yn(int[] array, int numb){
	for (int i = 0; i < array.Length; i++){
		if(array[i] == numb) return true;
	}
	return false;
}

Console.Write("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);

bool y = Yn(newArray, numb);
Console.WriteLine(y);
 */
// Задача 3. Задайте одномерный массив из m случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [a,b] включительно.

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

int Line(int[] array, int a, int b){
	int count = 0;
	for (int i = 0; i < array.Length; i++)
		if(array[i] >= a && array[i] <= b) count++;

	return count;
}


Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);

int count = Line(newArray, a, b);
Console.WriteLine(count);
