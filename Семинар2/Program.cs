﻿// Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.

int FindBiggerDigit(int num)
{
    int result;
    if(num < 10 || num >= 100)
        return 0;
    else
    {
        int ed = num % 10;
        int dec = num / 10;

        if(ed > dec)
            result = ed;
        else
            result = dec;
    }

    return result;
}

Console.Write("Input a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int biggerDigit = FindBiggerDigit(number);
Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");