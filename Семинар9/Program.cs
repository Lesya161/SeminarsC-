/*
int[,,] CreateRandom3dArray() 
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of width: ");
  int width = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minVal = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxVal = Convert.ToInt32(Console.ReadLine());

  int[,,] array = new int[rows, columns, width];

  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
      for (int k = 0; j < width; k++)
        array[i,j,k] = new Random().Next(minVal, maxVal+1);
  return array;
}

void Show3dArray(int[,,] array)  
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; j < array.GetLength(2); k++)
          Console.Write($"{array[i,j,k]} {i}, {j}, {k}");
    Console.WriteLine();
    }
  }
}


int[,,] array3d = CreateRandom3dArray();
Show3dArray(array3d);

*/


int[,] CreateRandom2dArray() 
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minVal = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxVal = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];

  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minVal, maxVal + 1);
  return array;
}
void Show2dArray(int[,] array)  
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
}
/*
void SortedArray(int[,] array)
{
int temp;
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int a = 0; a < array.GetLength(1); a++)
        if (array[i, a] > array[i, a + 1])
        {
          temp = array[i, a];
          array[i, a] = array[i, a + 1];
          array[i, a + 1] = temp;
        }
  }

int[,] oneArray = CreateRandom2dArray();
Show2dArray(oneArray);
SortedArray(oneArray);
Console.WriteLine();
Show2dArray(oneArray);
*/


int[,] Metod(int[,]oneArray,int[,] twoArray)
{
    if (oneArray.GetLength(0) == twoArray.GetLength(1))
    int[,] endArray = new int [oneArray.GetLength(0), twoArray.GetLength(1)];
    endArray[i,j] = 0;

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        endArray[i,j] = endArray[i,j] + oneArray[i,j] * twoArray[j,j];
    }

    }
    return endArray;
 }



int[,] oneMatrix = CreateRandom2dArray();
Show2dArray(oneMatrix);
int[,] twoMatrix = CreateRandom2dArray();
Show2dArray(twoMatrix);

Metod(oneMatrix,twoMatrix);
Show2dArray(resultMatrix);


