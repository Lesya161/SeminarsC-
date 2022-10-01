/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;

if(n1 == q2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

// Задача 2.Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;
if(n < 0)
{
    current = n;
    n = -n;
}
while(current <= n)
{
Console.Write(current + " ");
current++;
}
*\

// Деление на остатки...
/*
3162 % 10 -> 2
3162 % 100 -> 62
3162 % 1000 -> 162

3162 / 10 =316
3162 / 100 = 31
3162 / 1000 = 3
*/

// Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.
/*
Console.Write("Input a three-digit namber: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    int lastDigit = n % 10;
    Console.WriteLine($"Last digit of {n} is {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrect input!");
}
*/

// Домашка!!!
/*

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if(n1 > n2)
{
    max = n1;
}
else
{
    max = n2;
}

int min = n1;
if(n1 > n2)
{
    min = n2;
}
else
{
    min = n1;
}
Console.WriteLine($"max = {max} and min = {min}");

*/

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a fird number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if(n1 > max)
{
    max = n1;
}
if(n2 > max)
{
    max = n2;
}
if(n3 > max)
{
    max = n3;
}
Console.Write("max = ");
Console.WriteLine(max);