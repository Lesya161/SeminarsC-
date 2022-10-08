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
/*
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
*/
// либо
// bool Suc = Del(number,a,b);
// Console.WriteLine($"Ответ: {Suc}");


/*
bool CheckForWeekend(int week)
{
    if(week == 6 || week == 7)
        return true;
    else
        return false;
}

Console.Write("Enter the day of the week in a number: ");
int day = Convert.ToInt32(Console.ReadLine());
//bool result = CheckForWeekend(day);
//Console.WriteLine($"Entered day {day} of the weekend? {result}");
Console.WriteLine($"Entered day {day} of the weekend?");
Console.Write(CheckForWeekend(day));
*/

/*
string CheckForWeekend(int week)
{
    if(week < 1 || week >= 8)
        return "error - it is not day of week";
    else
    {
        if(week == 6 || week == 7)
            return "it is weekend";
        else
            return "it is work day";
    }
}

Console.Write("Enter the day of the week in a number: ");
int day = Convert.ToInt32(Console.ReadLine());
string result = CheckForWeekend(day);
Console.WriteLine($"Entered day {day} of the weekend?");
Console.WriteLine(result);
//Console.WriteLine($"Entered day {day} of the weekend?");
//Console.Write(CheckForWeekend(day));
*/


/*
int SecondDigit(int num)
{
    int result;
    int second;
    if(num < 100 || num > 1000)
        return -1;
    else
    {
        second = num / 10 % 10;
        result = second;
        return result;
    }
}

Console.WriteLine("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigitNumber = SecondDigit(number);
Console.WriteLine($"second digit of {number} is {secondDigitNumber}");
*/

