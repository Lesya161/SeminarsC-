//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    int num = 0;

    if(x > 0 && y > 0) num = 1;
    if(x < 0 && y > 0) num = 2;
    if(x < 0 && y < 0) num = 3;
    if(x > 0 && y < 0) num = 4;

    return num;
} 

Console.Write("Ввудите х координату: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввудите у координату: ");
double y = Convert.ToDouble(Console.ReadLine());

int quartNum = FindQuart(x,y);
Console.WriteLine($"Точка А ({x}, {y}) находится в {quartNum}");
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double FindDistans(double x, double x1, double y, double y1)
{
    double num = 0;
    num = (x1 - x)*(x1 - x) + (y1 - y)*(y1 - y);
    num = Math.Sqrt(num);
    return num;
}

Console.Write("Введите координату х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

double findDistans = FindDistans(x, x1, y, y1);
Console.Write(findDistans);
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.
/*
void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 2);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/
