// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num) 
{
  //Console.Write(num + " "); обратно от 5 до 1
  if(num > 1) ShowNums(num - 1);
  Console.Write(num + " ");
}

ShowNums(5);
*/


// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int SumOfDigits(int num) 
{
  if(num != 0) return SumOfDigits(num / 10) + num % 10;
  else return 0;
}

Console.WriteLine(SumOfDigits(1256));
*/


// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void NaturalNumbers(int m, int n) 
{
  if(m > n) 
  {
    NaturalNumbers(m - 1, n);
    Console.Write(m + " ");
  }
  if(m < n) 
  {
    NaturalNumbers(m, n - 1);
    Console.Write(n + " ");
  }
  if(m == n) 
    Console.Write(n + " ");
}
NaturalNumbers(10, 1);
*/


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double PowerAB(double a, int b)
{   if (b<0)return 1/a*PowerAB(a,b+1);
    if(b>0) return a*PowerAB(a,b-1);
    else return 1;
}
Console.WriteLine(PowerAB(2,-3));