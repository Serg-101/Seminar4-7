/*Задача 62: 
Заполните спирально массив 4 на 4.

 1   2   3   4
12  13  14   5
11  16  15   6
10   9   8   7

*/

void FillArr(byte[,] arr)
{
    byte rowMax = (byte)arr.GetLength(0);
    byte collMax = (byte)arr.GetLength(1);
    byte rowMin = 0, collMin = 0;
    byte i = 0, j = 0, value = 1;
    byte length = (byte) (rowMax-- * collMax--);
    arr[i,j]=value;
    do
    {
        while (j<collMax) arr[i,++j]=++value;
        rowMin++;
        while (i<rowMax) arr[++i,j]=++value;
        collMax--;
        while (j>collMin) arr[i,--j]=++value;
        rowMax--;
        while (i>rowMin) arr[--i,j]=++value;
        collMin++;
    } while (value<length);
}

void PrintArray(byte[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


System.Console.WriteLine("--------------------------");
byte[,] arr = new byte[4, 4];
FillArr(arr);
PrintArray(arr);
System.Console.WriteLine("--------------------------");

