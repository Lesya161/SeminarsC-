/*
int[] CreateArray(int size) 
{
  int[] array = new int[size];
  Console.WriteLine("Creating array: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Input a {i + 1} element of array: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Complete!");
  return array;
}
*/
int[] CreateRandomArray() 
{
    Console.Write("Input a numbers of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Minimal number of elements: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Maximal number of elements: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}

/*
int[] ChangeArray1(int[] array) 
{
  int[] newArray = new int[array.Length];
  for (int i = 1; i < array.Length; i++)
  {
    newArray[i] = array[i] + 10;
  }
  return newArray;
}
int[] myArray = CreateRandomArray();
int[] newArray = ChangeArray1(myArray);
//ShowArray(myArray);
//ShowArray(newArray);
//ShowArray(myArray);
*/

//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ChangeArray(int[] array) 
{
  for (int i = 0, j = array.Length - 1; i < j; i++, j--) 
  {
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
  }
}

int[] oneArray = CreateRandomArray();

ShowArray(oneArray);
ChangeArray(oneArray);
ShowArray(oneArray);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Каждая сторона триугольника должна быть строго меньше суммы двух других сторон
/*
bool Exist(int a, int b, int c)
{
    if(a+b>c && b+c>a && a+c>b)
        return true;
    else
        return false;
}
Console.Write(Exist(2, 2, 3));

// Console.Write("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Выедите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// bool exist = Exist(num1, num2, num3);
// if(exist)Console.Write("Треугольник возможен");
// else Console.Write("Треугольник не возможен");
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] Copy(int[] array) 
{
  int[] copyArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
    copyArray[i] = array[i];
   return copyArray;
}
int[] oneArray = CreateRandomArray();
int[] copyArray = Copy(oneArray);

ShowArray(oneArray);
ShowArray(copyArray);
ShowArray(oneArray);


//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
// Ряд фибоначи это числовая последовательность это каждый новый элемент является суммой первых двух элементов
/*
int[] Fibanaci(int size, int numOne, int numTwo) 
{
  int[] array = new int[size];
  array[0] = numOne;
  array[1] = numTwo;
  for (int i = 2; i < size; i++)
  {
    array[i] = array[i - 1] + array[i - 2];  
  }
  return array;
}

Console.Write("Напишите размер выводимого числа фибоначи: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите первое число фибоначи: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число фибоначи: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Последовательность числа фибоначи равна: ");
ShowArray(Fibanaci(size, numOne, numTwo));
*/
