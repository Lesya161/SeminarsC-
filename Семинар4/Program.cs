//На вход число, которое выдает сумму чисел от 1 до числа N
/*
int GetSum(int num)
{
    int sum = 0;
    for(int current = 1; current <= num; current++)
        sum += current; //sum = sum + current
    return sum;
}
Console.Write("Input a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int s = GetSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {s}");
*/

//На вход число, возвращ кол-во цифр в числе
/*
int CountInt(int num)
{
    int count = 0;
        if(num < 0) num = num * (-1);
        while (num > 0)
        {
            num = num / 10;
            count++;
        }
    return count;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"кол-во цифр в {a} - {CountInt(a)}");
*/
//На вход число, выход числа произведения от 1 до числа N
/*
int Factorial(int num)
{
    int f = 1;
    if(num < 0) return -1;
    for(int i = 1; num >= i; i++)
    {
        f = f * i;
    }
    return f;
}
Console.Write("Введите число: ");
int f = Convert.ToInt32(Console.ReadLine());
if(f == -1)
Console.WriteLine("Факториал не может быть отрицательным!");
else
Console.WriteLine($"Факториал числа {f} это {Factorial(f)}");
*/