// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* 
void Count(int size){
	int count = 0;
	for (int i = 0; i < size; i++){
		int num = Convert.ToInt32(Console.ReadLine());
		if(num > 0) count++;
	}
	Console.WriteLine();
	Console.WriteLine($"The number of elements > 0 = {count}");
}

Console.Write("Input the number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Count(size);
 */

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

void IntersectionOfLines(double k1, double b1, double k2, double b2){
	double x = (b2 - b1) / (k1 - k2);
	double y = k1 * x + b1;
	if (k1 == k2) Console.WriteLine("Решений нет");
	else Console.WriteLine($"{Math.Round(x, 2)}, {Math.Round(y, 2)}");
}

Console.Write("Input the b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionOfLines(k1, b1, k2, b2);