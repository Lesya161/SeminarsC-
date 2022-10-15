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
