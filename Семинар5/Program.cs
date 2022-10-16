//запрос от пользователя на элементы
/*
int[] NewArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Add next element."); 
        array[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Well done!");
    }
    return array;
}
*/

//Универвальные методы для того чтобы задать массив и его показать
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}
*/

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum = sum + array[i]; // sum += array[i]
    }
    return sum;
}

Console.Write("Введите число элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size, min, max);
ShowArray(myArray);

int result = SumOfNegatives(myArray);
Console.WriteLine("сумма отриц элементов это " + result);
*/

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] ReversArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);
    return array;
}

Console.Write("Введите число элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] thisArray = CreateArray(size, min, max);
ShowArray(thisArray);
thisArray = ReversArray(thisArray);
ShowArray(thisArray);
*/

//Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int Current(int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 100 && array[i] > 9)
        current++;
    }
    return current;
}

Console.Write("Введите число элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
ShowArray(array);
int result = Current(array);
Console.WriteLine("Число двузначных эдементов массива: " + result);
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool YourNumber(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        return true;
    }
    return false;
}

Console.Write("Введите число элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс элемент: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] endArray = CreateArray(size, min, max);
ShowArray(endArray);
Console.Write("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше число есть в массиве? " + YourNumber(endArray, number));
*/
//после инт намбер
//if(YourNumber(endArray, number))
//    Console.WriteLine("Твое число есть в массиве");
//else
//    Console.WriteLine("Твоего числа нет в массиве");


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}

//1
/*
int ShowEvenElementsNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Minimal number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Maximal number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] threeDigitArray = CreateRandomArray(size, min, max);
ShowArray(threeDigitArray);
int result = ShowEvenElementsNumbers(threeDigitArray);
Console.WriteLine($"In your array {result} even elements.");
*/


//2
/*
int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}

Console.Write("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Minimal number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Maximal number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] randomArray = CreateRandomArray(size, min, max);
ShowArray(randomArray);
int result = SumElements(randomArray);
Console.WriteLine($"The sum of your array in uneven elements is {result}.");
*/

//3
/*
double[] CreateDoubleArray(int size)
{
    double[] array = new double [size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Write element of array: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}

double FindMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > max) max = array[i];

    for(int i = 0; i < array.Length; i++)
        if(array[i] < min) min = array[i];

    result = max - min;
    result = Math.Round(result, 2);
    return result;
}

Console.Write("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] endArray = CreateDoubleArray(size);
ShowDoubleArray(endArray);
double differens = FindMinMax(endArray);

Console.WriteLine($"In your array differens max and mun is {differens}.");
*/
