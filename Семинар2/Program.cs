// Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.
/*
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
*/

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int RemoveSecond(int num)
{
    int ed = num % 10;
    int doc = num / 100;
    int result = doc * 10 + ed;
    return result;
}

int number = new Random().Next(100,1000);
Console.WriteLine(number);
Console.WriteLine(RemoveSecond(number));

// Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b(целочисленные делители, также задаются пользователем).
