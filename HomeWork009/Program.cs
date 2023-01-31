// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/* 
void ShowNums(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums(n - 1);
}

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
 */

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/* 
int SumOfNums(int m, int n)
{
    if (m < n) return SumOfNums(m + 1, n) + m;
    else if (m == n) return m;
    else return -1;
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNums(m, n));
 */

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckerF(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m != 0)
        return AckerF(m - 1, 1);
    else
        return AckerF(m - 1, AckerF(m, n - 1));
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckerF(m, n));