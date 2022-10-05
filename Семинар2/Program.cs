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
/*
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
*/
// Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b(целочисленные делители, также задаются пользователем).

bool Del(int num, int num1, int num2)
{
    if(num % num1 == 0 && num % num2 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый делитель: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй делитель: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: {Del(number,a,b)}");
// либо
// bool Suc = Del(number,a,b);
// Console.WriteLine($"Ответ: {Suc}");