/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,,] FillArray(int firstDemension, int secondDemention, int thirdDemention)
{
    int count = 0;
    int[,,] arr = new int[firstDemension, secondDemention, thirdDemention];
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemention; j++)
        {
            for (int k = 0; k < thirdDemention; k++)
            {
                arr[i, j, k] = count++;
            }
        }
    }
    return arr;
}


void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
            }
            System.Console.WriteLine();    
        }
        System.Console.WriteLine();
    }
}


Console.Clear();
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int thirdDemention = GetDemension("Введите размер третьего разряда: ");
int[,,] array = FillArray(firstDemension, secondDemention,thirdDemention);
System.Console.WriteLine();
System.Console.WriteLine("массив чисел");
PrintArray(array);