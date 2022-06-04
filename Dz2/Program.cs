/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.*/

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

int SortArray(int[,] arr)
{
    int[] summ = new int[arr.GetLength(0)];
    int[] numRow = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        numRow[i] = i;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ[i] += arr[i, j];
        }
    }
    Array.Sort(summ,numRow); // сортируем по первому массиву summ
    System.Console.WriteLine("два одномерных массива отсортированые по возростанию");
    System.Console.WriteLine("в первом суммы строк, во втором номера строк");
    System.Console.WriteLine("сумм\tстрока");
    for (int i = 0; i < summ.Length; i++)
        System.Console.WriteLine(" {0}\t   {1}",summ[i],numRow[i]);
    return numRow[0];
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            System.Console.Write($"{arr[i, j]}\t");
        System.Console.WriteLine();
    }
}

Console.Clear();
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int[,] arr = FillArray(firstDemension, secondDemention);
System.Console.WriteLine();
System.Console.WriteLine("массив чисел");
PrintArray(arr);
System.Console.WriteLine();
int minColl = SortArray(arr);
System.Console.WriteLine($"Первая строка с наименьшей суммой элементов {minColl}");
Console.ReadKey();