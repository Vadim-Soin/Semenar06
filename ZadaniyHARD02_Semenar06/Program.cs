Console.Write("Введите количество строк таблици  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов таблици  ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[x, y];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
MaxArray(array);
MinArray(array);
Console.WriteLine();


void PrintArray(int[,] array)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] array)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}


void MaxArray(int[,] array)
{
    int max = array[0, 0];
    int index1 = 0;
    int index2 = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (max < array[i, j])
            {
                max = array[i, j];
                index1 = i;
                index2 = j;
            }
        }

    }
    Console.WriteLine($"Максимальное число {max}, индекс числа ({index1}, {index2}) ");
}


void MinArray(int[,] array)
{
    int min = array[0, 0];
    int index1 = 0;
    int index2 = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                index1 = i;
                index2 = j;
            }
        }

    }
    Console.WriteLine($"Минимальное число {min}, индекс числа ({index1}, {index2}) ");
}









