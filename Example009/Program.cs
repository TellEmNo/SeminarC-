// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/* 
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);
 */

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/* 
int GetSumOfDigits(int num)
{
    if (num != 0) return GetSumOfDigits(num / 10) + num % 10;
    else return 0;
}
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSumOfDigits(num));
 */
// f(1234) -> 4 + f(123) = 4 + 6
// f(123) -> 3 + f(12) = 3 + 3
// f(12) -> 2 + f(1) = 2 + 1
// f(1) -> 1 + f(0) = 1 + 0 

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/* 
void ShowNums(int n, int m)
{
    if (m > n)
    {
        Console.Write(m + " ");
        ShowNums(m - 1, n);
    }
    else if (n > m)
    {
        Console.Write(n + " ");
        ShowNums(m, n - 1);
    }
    else Console.Write(m);
}

ShowNums(3, 3);
 */
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/* 
double PowAtoB(double a, double b)
{
    if (b > 0) return a * PowAtoB(a, b - 1);
    else if (b < 0) return (1 / a) * PowAtoB(a, b + 1);
    else return 1;
}

Console.Write(PowAtoB(2, -3));
 */

// Алгоритм сортировки слиянием - посмотреть