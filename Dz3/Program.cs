/*Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.*/

int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,] FillArray(int firstDemension, int secondDemention)
{
    Random rnd = new Random();
    int[,] arr = new int[firstDemension, secondDemention];
    for (int i = 0; i < firstDemension; i++)
        for (int j = 0; j < secondDemention; j++) arr[i, j] = rnd.Next(0, 10);
    return arr;
}

int[,] MultiplyArray(int[,] arr1, int[,] arr2)
{
    int[,] arrResult = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr1.GetLength(1); j++)
            arrResult[i, j] = arr1[i, j] * arr2[i, j];
    return arrResult;
}

void PrintArray(int[,] arr)
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

void PrintBothArray(int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            System.Console.Write($"{arr1[i, j]}\t");
        }
        System.Console.Write("\t\t");
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            System.Console.Write($"{arr2[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int[,] arrayOne = FillArray(firstDemension, secondDemention);
int[,] arrayTwo = FillArray(firstDemension, secondDemention);
System.Console.WriteLine();
System.Console.WriteLine("массивы чисел");
PrintBothArray(arrayOne, arrayTwo);
System.Console.WriteLine();
int[,] resultArray = MultiplyArray(arrayOne,arrayTwo);
System.Console.WriteLine("произведение элементов массива");
PrintArray(resultArray);
Console.ReadKey();