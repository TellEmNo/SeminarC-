/* 
void ShowNum(int[] a){
	a[0] += 5;
	Console.WriteLine(a[0]);
}

int[] num = { 5, 7, 3 };

ShowNum(num);
Console.WriteLine(num[0]);
 */
// массив - ссылочный тип данных, поэтому массив передаваемый в метод,
// будет изменяться и в методе и вне его

// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/* 
int[] RandomArray(int size, int minValue, int maxValue){
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
		array[i] = new Random().Next(minValue, maxValue + 1);
	return array;
}
void ShowArray(int[] array){
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}
//Вариант использования цикла for
void ReverseArray(int[] array){
	for (int i = 0, j = array.Length - 1; i < j; i++, j--)
	{
		int temp = array[i];
		array[i] = array[j];
		array[j] = temp;
	}
}
Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(Length, min, max);

ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
 */

// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины. a + b > c, b + c > a, a + c > b
/* 
bool Triangle(int a, int b, int c){
	if(a + b > c && b + c > a && a + c > b) return true;
	else return false;
}

Console.Write("Введеите длину первой стороны: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите длину второй стороны: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите длину третьей стороны: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(a, b, c));
 */
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/* 
int[] RandomArray(int size, int firstNumber, int secondNumber){
	int[] array = new int[size];
	array[0] = firstNumber;
	array[1] = secondNumber;
	for (int i = 2; i < size; i++)
		array[i] = array[i-1] + array[i-2];
	return array;
}
void ShowArray(int[] array){
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first element: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second element: ");
int second = Convert.ToInt32(Console.ReadLine());

int[] result = RandomArray(Length, first, second);

ShowArray(result);
 */
// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

int[] RandomArray(int size, int minValue, int maxValue){
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
		array[i] = new Random().Next(minValue, maxValue + 1);
	return array;
}
void ShowArray(int[] array){
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}

int[] CopyArray(int[] array, int size){
	int[] newArray = new int[size];
	for (int i = 0; i < size; i++)
		newArray[i] = array[i];
	return newArray;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);
int[] result = CopyArray(newArray, m);
ShowArray(newArray);