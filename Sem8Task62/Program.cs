PrintArray(SpiralFill());

int[,] SpiralFill()
{
    int[,] spiralArray = new int[4, 4];
    spiralArray[0,0] = 1;
    for(int i = 0; i < 3; i++)
    {
        spiralArray[0, i+1] = spiralArray[0, i] + 1;
    }
    for(int j = 0; j < 3; j++)
    {
        spiralArray[j+1, 3] = spiralArray[j,3] + 1;
    }
    for(int k = 3; k > 0; k--)
    {
        spiralArray[3, k-1] = spiralArray[3, k] + 1;
    }
     for(int l = 3; l > 1; l--)
    {
        spiralArray[l-1, 0] = spiralArray[l,0] + 1;
    }
     for(int m = 0; m < 2; m++)
    {
        spiralArray[1, m+1] = spiralArray[1, m] + 1;
    }
       for(int n = 1; n < 3; n++)
    {
        spiralArray[n+1, 2] = spiralArray[n,2] + 1;
    }
      for(int o = 3; o > 0; o--)
    {
        spiralArray[2, o-1] = spiralArray[2, o] + 1;
    }
    return spiralArray;
}

void PrintArray(int[,] array)
{
    //cycle of array printing
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}