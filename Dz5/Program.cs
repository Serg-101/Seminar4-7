
int GetDemension(string message)
{
    System.Console.Write(message);
    while (true)
        if (int.TryParse(System.Console.ReadLine(),out int number))
            return number;
        else
            System.Console.WriteLine("Неправильный ввод, необходимо целое число больше 0");
}

void FillArr(byte[,] arr)
{
    byte rowMax = (byte)arr.GetLength(0);
    byte collMax = (byte)arr.GetLength(1);
    byte rowMin = 0, collMin = 0;
    byte i = 0, j = 0, value = 1;
    byte length = (byte)(rowMax-- * collMax--);
    arr[i, j] = value;
    do
    {
        while (j < collMax && value < length) arr[i, ++j] = ++value;
        rowMin++;
        while (i < rowMax && value < length) arr[++i, j] = ++value;
        collMax--;
        while (j > collMin && value < length) arr[i, --j] = ++value;
        rowMax--;
        while (i > rowMin && value < length) arr[--i, j] = ++value;
        collMin++;
    } while (value < length);
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

Console.Clear();
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
if (firstDemension > 0 & secondDemention > 0)
{
    System.Console.WriteLine("--------------------------");
    byte[,] arr = new byte[firstDemension, secondDemention];
    FillArr(arr);
    PrintArray(arr);
    System.Console.WriteLine("--------------------------");
}
else
    System.Console.WriteLine("введено нулевое значение!");
