/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.Clear();

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

void SortArray(int[,] arr)   // применим поразрядную сортировку (или Radix sort), зная кол-во разрядов (10).
{
    int[] tmparr = new int[10];
    int k = 0, len = 0, value = 0;
    int length0 = arr.GetLength(0);
    int length1 = arr.GetLength(1);
    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            value = arr[i, j];
            k = k < value ? value : k;
            tmparr[value]++;
        }
        while (len < length1)
        {
            while (tmparr[k] == 0) k--;
            arr[i, len] = k;
            tmparr[k]--;
            len++;
        }
        len = 0;
        k = 0;
    }

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


int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int[,] arr = FillArray(firstDemension, secondDemention);
System.Console.WriteLine();
System.Console.WriteLine("массив чисел");
PrintArray(arr);
SortArray(arr);
System.Console.WriteLine();
System.Console.WriteLine("массив с отсортированными строками");
PrintArray(arr);
Console.ReadKey(); 
